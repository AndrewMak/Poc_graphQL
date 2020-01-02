# Poc_graphQL
query collections {
  collections {
    name
    description
    securities {
      rentabilityType
      incomeTaxFree,
      incomeTaxDescription
      index
      indexType
      isGuaranteedByFgc
      issuerName
      liquidity
      liquidityDescription
      maturity
      maturityDays
      maturityDescription
      nickname
      price
      ratingDescription
      relativeRentability
      securityImplementationType
      simulatedRentability
      simulatedInvestmentValue
      stockQuantity
      yield
      percentIndex
      incomeTaxRate
      securityId
      securityNameType
      securityType
      rentability
      minTick
      suitability
      isQualified
      isPromotion
      
    }
  }
}
