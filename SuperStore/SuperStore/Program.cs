using SuperStore.Services;

var service = new SuperStoreService();

var cheapestProduct = service.FindCheapestProduct();

var mostExpensive = service.FindMostExpensiveProductFromCategory("Category #1");

var productsBelowAvg = service.GetAllProductsWithPriceBelowAverage("Category #2");

var display = service.GetProductCategoryDetails();

Console.Read();
