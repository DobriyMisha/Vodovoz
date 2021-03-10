using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BitrixApi.DTO {
    public class ProductFromDealRequest {
        [JsonProperty("result")] public IList<ProductFromDeal> Result { get; set; }
        [JsonProperty("time")] public ResponseTime ResponseTime { get; set; }
    }
    
    public class ProductFromDeal {
        // [JsonProperty("ID")]  public uint Id { get; set; }
        [JsonProperty("OWNER_ID")]  public string OWNER_ID { get; set; }
        [JsonProperty("OWNER_TYPE")] public string OWNER_TYPE { get; set; } 
        //Вот это настоящий BitrixId товара
        [JsonProperty("PRODUCT_ID")] public uint ProductId { get; set; }
        [JsonProperty("PRODUCT_NAME")] public string ProductName { get; set; }
        [JsonProperty("PRODUCT_DESCRIPTION")] public string ProductDescription { get; set; }
        [JsonProperty("PRICE")] public decimal Price { get; set; }
        [JsonProperty("PRICE_EXCLUSIVE")] public decimal PRICE_EXCLUSIVE { get; set; }
        [JsonProperty("PRICE_NETTO")] public decimal PRICE_NETTO { get; set; }
        [JsonProperty("SECTION_ID")] public string PRICE_ACCOUNT { get; set; }
        
        [JsonProperty("QUANTITY")] public int Count { get; set; }
        [JsonProperty("DISCOUNT_TYPE_ID")] public int DISCOUNT_TYPE_ID { get; set; }
        [JsonProperty("DISCOUNT_RATE")] public int DISCOUNT_RATE { get; set; }
        [JsonProperty("DISCOUNT_SUM")] public int DISCOUNT_SUM { get; set; }
        [JsonProperty("TAX_RATE")] public int TAX_RATE { get; set; }
        [JsonProperty("TAX_INCLUDED")] public string TAX_INCLUDED { get; set; } // Bool
        [JsonProperty("CUSTOMIZED")] public string CUSTOMIZED { get; set; }
        [JsonProperty("MEASURE_CODE")] public string MEASURE_CODE { get; set; }
        [JsonProperty("MEASURE_NAME")] public string MeasureName { get; set; } // шт
    }
}