using System.Collections.Generic;

public class PaymentLoader
{
	private static List<int> listPaymentID;

	private static Dictionary<int, PaymentOriData> oriDatas;

	private static Dictionary<string, PaymentOriData> sku2OriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetPaymentKindIDs()
	{
		return null;
	}

	public static PaymentOriData GetPaymentOriData(int ID)
	{
		return null;
	}

	public static Dictionary<int, PaymentOriData> GetAllPaymentOriData()
	{
		return null;
	}

	public static string getSkuArray()
	{
		return null;
	}

	public static void GetShopBuyTypeId(string productId, ref ShopBuyType shop_buy_type, ref int shop_buy_id)
	{
	}

	public static string GetProductID(ShopBuyType shop_buy_type, int shop_buy_id)
	{
		return null;
	}
}
