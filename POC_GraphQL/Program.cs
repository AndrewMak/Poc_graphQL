using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using POC_GraphQL.Database;

namespace POC_GraphQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = CreateWebHostBuilder(args).Build();

            using (var db = new StoreContext())
            {
                var authorDbEntry = db.Collections.Add(
                    new Collection
                    {
                        Name = "CRI e CRA",
                        Description = "São dois tipos de investimento em renda fixa de médio e longo prazo isentos de Imposto de Renda, que trazem a possibilidade de optar por taxas pré ou pós fixadas, com remunerações e amortizações no período da aplicação. CRI (Certificados de Recebíveis Imobiliários), e CRA (Certificados de Recebíveis Agrícolas) são considerados investimentos de baixo risco e são emitidos por companhias securitizadoras.\n\nEsses investimentos não contam com a cobertura do Fundo Garantidor de Crédito."
                    }
                );

                db.SaveChanges();

                db.Securities.AddRange(
                new Security
                {
                    CollectionId = authorDbEntry.Entity.Id,
                    rentabilityType = 3,
                    incomeTaxFree = true,
                    incomeTaxDescription = "Isento de IR",
                    index = "IGPM",
                    indexType = 2,
                    isGuaranteedByFgc = false,
                    issuerName = "FORTE SECURITIZADORA",
                    liquidity = 0,
                    liquidityDescription = "no vcto.",
                    maturity = DateTime.Now.AddYears(5),
                    maturityDays = 1960,
                    maturityDescription = "1960 dias",
                    nickname = "CRI GOLDEN GRAMADO 138ª",
                    price = 1054.73,
                    ratingDescription = "",
                    relativeRentability = 0.0,
                    securityImplementationType = 1,
                    simulatedRentability = 0.0,
                    simulatedInvestmentValue = null,
                    stockQuantity = 24.0,
                    yield = 6.75,
                    percentIndex = 100.0,
                    incomeTaxRate = 0.0,
                    securityId = "FIXEDINCOME.CRI.7385",
                    securityNameType = "CRI",
                    securityType = "CRI",
                    rentability = "IGPM + 6.75%",
                    minTick = 1054.73,
                    suitability = 3,
                    isQualified = true,
                    isPromotion = true
                },
                   new Security
                   {
                       CollectionId = authorDbEntry.Entity.Id,
                       rentabilityType = 3,
                       incomeTaxFree = true,
                       incomeTaxDescription = "Isento de IR",
                       index = "IGPM",
                       indexType = 2,
                       isGuaranteedByFgc = false,
                       issuerName = "VERT SECURITIZADORA",
                       liquidity = 0,
                       liquidityDescription = "no vcto.",
                       maturity = DateTime.Now.AddYears(5),
                       maturityDays = 1960,
                       maturityDescription = "1960 dias",
                       nickname = "CRI GOLDEN GRAMADO 138ª",
                       price = 2044.73,
                       ratingDescription = "",
                       relativeRentability = 0.5,
                       securityImplementationType = 1,
                       simulatedRentability = 0.0,
                       simulatedInvestmentValue = null,
                       stockQuantity = 50.0,
                       yield = 6.15,
                       percentIndex = 100.0,
                       incomeTaxRate = 0.0,
                       securityId = "FIXEDINCOME.CRI.72155",
                       securityNameType = "CRI",
                       securityType = "CRI",
                       rentability = "IGPM + 6.15%",
                       minTick = 1054.73,
                       suitability = 3,
                       isQualified = true,
                       isPromotion = true
                   },
                      new Security
                      {
                          CollectionId = authorDbEntry.Entity.Id,
                          rentabilityType = 3,
                          incomeTaxFree = true,
                          incomeTaxDescription = "Isento de IR",
                          index = "IGPM",
                          indexType = 2,
                          isGuaranteedByFgc = false,
                          issuerName = "FORTE SECURITIZADORA",
                          liquidity = 0,
                          liquidityDescription = "no vcto.",
                          maturity = DateTime.Now.AddYears(5),
                          maturityDays = 1960,
                          maturityDescription = "5150 dias",
                          nickname = "CRI GOLDEN GRAMADO 138ª",
                          price = 3458.65,
                          ratingDescription = "",
                          relativeRentability = 0.0,
                          securityImplementationType = 1,
                          simulatedRentability = 0.0,
                          simulatedInvestmentValue = null,
                          stockQuantity = 35.0,
                          yield = 9.75,
                          percentIndex = 100.0,
                          incomeTaxRate = 0.0,
                          securityId = "FIXEDINCOME.CRI.7345455",
                          securityNameType = "CRI",
                          securityType = "CRI",
                          rentability = "IGPM + 9.75%",
                          minTick = 1054.73,
                          suitability = 3,
                          isQualified = true,
                          isPromotion = true
                      }
                );

                db.SaveChanges();
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
