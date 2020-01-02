using System;

namespace POC_GraphQL.Database 
{
    public class Security
    {
        public int rentabilityType { get; set; }
        public bool incomeTaxFree { get; set; }
        public string incomeTaxDescription { get; set; }
        public string index { get; set; }
        public int indexType { get; set; }
        public bool isGuaranteedByFgc { get; set; }
        public string issuerName { get; set; }
        public int liquidity { get; set; }
        public string liquidityDescription { get; set; }
        public DateTime maturity { get; set; }
        public int maturityDays { get; set; }
        public string maturityDescription { get; set; }
        public string nickname { get; set; }
        public double price { get; set; }
        public string ratingDescription { get; set; }
        public double relativeRentability { get; set; }
        public int securityImplementationType { get; set; }
        public double simulatedRentability { get; set; }
        public string simulatedInvestmentValue { get; set; }
        public double stockQuantity { get; set; }
        public double yield { get; set; }
        public double percentIndex { get; set; }
        public double incomeTaxRate { get; set; }
        public string securityId { get; set; }
        public string securityNameType { get; set; }
        public string securityType { get; set; }
        public string rentability { get; set; }
        public double minTick { get; set; }
        public int suitability { get; set; }
        public bool isQualified { get; set; }
        public bool isPromotion { get; set; }

        public int CollectionId { get; set; }

        public Collection Collection { get; set; }
    }
}