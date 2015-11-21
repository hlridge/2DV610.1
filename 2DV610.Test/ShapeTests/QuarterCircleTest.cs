﻿using System;
using Xunit;
using Xunit.Abstractions;
using _2DV610;
using _2DV610.Classes;

namespace _2DV610.Test
{
    public class QuarterCircleTest
    {
        private readonly ITestOutputHelper output;

        public QuarterCircleTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        //[Fact]
        //public void ShouldBeCorrectShapeType()
        //{
        //    QuarterCircle sut = new QuarterCircle();

        //    Assert.Equal(ShapeType.QuarterCircle, sut.ShapeType);
        //}

        [Fact]
        public void ConstructorShouldSetCorrectValues()
        {
            int cx = 84;
            int cy = 64;
            int radius = 32;

            QuarterCircle sut = new UpperLeftQuarterCircle(cx, cy, radius);

            Assert.Equal(cx, sut.CX);            
            Assert.Equal(cy, sut.CY);            
            Assert.Equal(radius, sut.Radius);
        }
    }
}
