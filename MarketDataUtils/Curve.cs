using System;
using System.Collections.Generic;
using Base;

namespace MarketDataUtils
{
    public abstract class Curve
    {
        public List<double> Tenors { get; }
        public List<double> Rates { get; }
        public List<double> DiscountFactors { get; }
        public  IRCompoundingConvention IrCompoundingConvention { get; }
        
        public Curve(List<double> tenors, List<double> rates, IRCompoundingConvention irCompoundingConvention)
        {
            Tenors = tenors;
            Rates = rates;
            IrCompoundingConvention = irCompoundingConvention;
        }

        public Curve(List<double> tenors, List<double> discountFactors)
        {
            Tenors = tenors;
            DiscountFactors = discountFactors;
        }
        
        public abstract List<double> GetDiscountFactors(double tenors);

        public abstract List<double> GetForwardRates(double tenors);
        
        public abstract List<double> GetZeroRates(double tenors);
    }
}