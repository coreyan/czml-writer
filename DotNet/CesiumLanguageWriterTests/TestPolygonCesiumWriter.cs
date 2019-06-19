﻿using System;
using System.Collections.Generic;
using System.Drawing;
using CesiumLanguageWriter;
using CesiumLanguageWriter.Advanced;
using NUnit.Framework;

namespace CesiumLanguageWriterTests
{
    [TestFixture]
    public class TestPolygonCesiumWriter : TestCesiumPropertyWriter<PolygonCesiumWriter>
    {
        [Test]
        public void TestShowProperty()
        {
            using (Packet)
            using (var polygon = Packet.OpenPolygonProperty())
            using (var interval = polygon.OpenInterval())
            {
                interval.WriteShowProperty(true);
            }

            Assert.AreEqual("{\"polygon\":{\"show\":true}}", StringWriter.ToString());
        }

        [Test]
        public void TestShowPropertyInterval()
        {
            var startDate = new JulianDate(new GregorianDate(2012, 4, 2, 12, 0, 0));
            var stopDate = new JulianDate(new GregorianDate(2012, 4, 2, 12, 1, 0));

            using (Packet)
            using (var polygon = Packet.OpenPolygonProperty())
            using (var show = polygon.OpenShowProperty())
            using (var showIntervals = show.OpenMultipleIntervals())
            {
                using (var interval = showIntervals.OpenInterval(startDate, startDate.AddSeconds(1)))
                {
                    interval.WriteBoolean(true);
                }

                using (var interval = showIntervals.OpenInterval(startDate.AddSeconds(1), startDate.AddSeconds(2)))
                {
                    interval.WriteBoolean(false);
                }

                using (var interval = showIntervals.OpenInterval(startDate.AddSeconds(2), stopDate))
                {
                    interval.WriteBoolean(true);
                }
            }

            string interval1String = CesiumFormattingHelper.ToIso8601Interval(startDate, startDate.AddSeconds(1), Iso8601Format.Compact);
            string interval2String = CesiumFormattingHelper.ToIso8601Interval(startDate.AddSeconds(1), startDate.AddSeconds(2), Iso8601Format.Compact);
            string interval3String = CesiumFormattingHelper.ToIso8601Interval(startDate.AddSeconds(2), stopDate, Iso8601Format.Compact);

            Assert.AreEqual("{\"polygon\":{\"show\":[{\"interval\":\"" + interval1String + "\",\"boolean\":true}," +
                            "{\"interval\":\"" + interval2String + "\",\"boolean\":false}," +
                            "{\"interval\":\"" + interval3String + "\",\"boolean\":true}" +
                            "]}}", StringWriter.ToString());
        }

        [Test]
        public void TestHoles()
        {
            using (Packet)
            using (var polygon = Packet.OpenPolygonProperty())
            using (var holes = polygon.OpenHolesProperty())
            {
                var listOfHoles = new List<List<Cartographic>>
                {
                    new List<Cartographic> { new Cartographic(1, 1, 0), new Cartographic(1, 2, 0), new Cartographic(2, 2, 0), },
                    new List<Cartographic> { new Cartographic(4, 4, 0), new Cartographic(4, 5, 0), new Cartographic(5, 5, 0), new Cartographic(5, 4, 0), },
                };
                holes.WriteCartographicDegrees(listOfHoles);
            }

            Assert.AreEqual("{\"polygon\":{\"holes\":{\"cartographicDegrees\":[[1,1,0,1,2,0,2,2,0],[4,4,0,4,5,0,5,5,0,5,4,0]]}}}", StringWriter.ToString());
        }

        [Test]
        public void TestHolesIntervals()
        {
            var startDate = new JulianDate(new GregorianDate(2012, 4, 2, 12, 0, 0));
            var stopDate = new JulianDate(new GregorianDate(2012, 4, 2, 13, 0, 0));

            using (Packet)
            using (var polygon = Packet.OpenPolygonProperty())
            using (var holes = polygon.OpenHolesProperty())
            {
                using (var holesIntervals = holes.OpenMultipleIntervals())
                {
                    using (var interval = holesIntervals.OpenInterval(startDate, startDate.AddSeconds(60 * 30)))
                    {
                        var listOfHoles = new List<List<Cartographic>>
                        {
                            new List<Cartographic> { new Cartographic(1, 1, 0), new Cartographic(1, 2, 0), new Cartographic(2, 2, 0), },
                            new List<Cartographic> { new Cartographic(4, 4, 0), new Cartographic(4, 5, 0), new Cartographic(5, 5, 0), new Cartographic(5, 4, 0), },
                        };
                        interval.WriteCartographicDegrees(listOfHoles);
                    }

                    using (var interval = holesIntervals.OpenInterval(startDate.AddSeconds(60 * 30), stopDate))
                    {
                        var listOfHoles = new List<List<Cartographic>>
                        {
                            new List<Cartographic> { new Cartographic(-1, -1, 0), new Cartographic(-1, -2, 0), new Cartographic(-2, -2, 0), },
                            new List<Cartographic> { new Cartographic(-4, -4, 0), new Cartographic(-4, -5, 0), new Cartographic(-5, -5, 0), new Cartographic(-5, -4, 0), },
                        };
                        interval.WriteCartographicDegrees(listOfHoles);
                    }
                }
            }

            Assert.AreEqual("{\"polygon\":{\"holes\":[" +
                            "{\"interval\":\"20120402T12Z/20120402T1230Z\",\"cartographicDegrees\":[[1,1,0,1,2,0,2,2,0],[4,4,0,4,5,0,5,5,0,5,4,0]]}," +
                            "{\"interval\":\"20120402T1230Z/20120402T13Z\",\"cartographicDegrees\":[[-1,-1,0,-1,-2,0,-2,-2,0],[-4,-4,0,-4,-5,0,-5,-5,0,-5,-4,0]]}" +
                            "]}}", StringWriter.ToString());
        }

        [Test]
        public void TestExample()
        {
            var outputStream = new CesiumOutputStream(StringWriter)
            {
                PrettyFormatting = true
            };
            var writer = new CesiumStreamWriter();

            using (var packet = writer.OpenPacket(outputStream))
            {
                packet.WriteId("examplePolygon");

                using (var polygon = packet.OpenPolygonProperty())
                {
                    using (var positions = polygon.OpenPositionsProperty())
                    {
                        var listOfPositions = new List<Cartographic> { new Cartographic(0, 0, 0), new Cartographic(0, 10, 0), new Cartographic(10, 10, 0), new Cartographic(10, 0, 0), };
                        positions.WriteCartographicDegrees(listOfPositions);
                    }

                    using (var holes = polygon.OpenHolesProperty())
                    {
                        var listOfHoles = new List<List<Cartographic>>
                        {
                            new List<Cartographic> { new Cartographic(1, 1, 0), new Cartographic(1, 2, 0), new Cartographic(2, 2, 0), },
                            new List<Cartographic> { new Cartographic(4, 4, 0), new Cartographic(4, 5, 0), new Cartographic(5, 5, 0), new Cartographic(5, 4, 0), },
                        };
                        holes.WriteCartographicDegrees(listOfHoles);
                    }

                    using (var material = polygon.OpenMaterialProperty())
                    {
                        using (var solidColor = material.OpenSolidColorProperty())
                        {
                            solidColor.WriteColorProperty(Color.Red);
                        }
                    }
                }
            }

            Console.WriteLine(StringWriter.ToString());
        }

        protected override CesiumPropertyWriter<PolygonCesiumWriter> CreatePropertyWriter(string propertyName)
        {
            return new PolygonCesiumWriter(propertyName);
        }
    }
}