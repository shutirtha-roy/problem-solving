public class StockSpanner 
{
    private readonly List<int> _priceList;

    public StockSpanner() 
    {
        _priceList = new List<int>();
    }

    private void AddPrice(int price) 
    {
        _priceList.Add(price);
    }
    
    public int Next(int price) 
    {
        AddPrice(price);

        var maxCount = 1;
        var count = 1;

        for(var index = _priceList.Count - 2; index >= 0; index--)
        {
            if(_priceList[index] <= price)
            {
                count++;
                continue;
            }

            break;
        }

        return Math.Max(maxCount, count);
    }
}