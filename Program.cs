using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace CryptoAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://apiv2.bitcoinaverage.com/exchanges/ticker/bitstamp");
                webRequest.Method = "GET";
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

                string jsonString;
                using (Stream stream = webResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    jsonString = reader.ReadToEnd();
                }
                Console.WriteLine(jsonString);
            }
            catch (Exception e)
            {

                Console.WriteLine(e); ;
            }
        }
    }
}


#region Currency
public class XRPBTC
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class LTCUSD
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class BTCUSD
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class XRPEUR
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class LTCEUR
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class ETHBTC
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class BCHEUR
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class BCHUSD
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class LTCBTC
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class ETHUSD
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class ETHEUR
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class BCHBTC
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class BTCEUR
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}

public class XRPUSD
{
    public double last { get; set; }
    public double volume { get; set; }
    public double ask { get; set; }
    public double bid { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double vwap { get; set; }
    public string exchange_symbol { get; set; }
}
#endregion

public class Symbols
{
    public XRPBTC XRPBTC { get; set; }
    public LTCUSD LTCUSD { get; set; }
    public BTCUSD BTCUSD { get; set; }
    public XRPEUR XRPEUR { get; set; }
    public LTCEUR LTCEUR { get; set; }
    public ETHBTC ETHBTC { get; set; }
    public BCHEUR BCHEUR { get; set; }
    public BCHUSD BCHUSD { get; set; }
    public LTCBTC LTCBTC { get; set; }
    public ETHUSD ETHUSD { get; set; }
    public ETHEUR ETHEUR { get; set; }
    public BCHBTC BCHBTC { get; set; }
    public BTCEUR BTCEUR { get; set; }
    public XRPUSD XRPUSD { get; set; }
}

public class RootObject
{
    public string name { get; set; }
    public string display_name { get; set; }
    public string url { get; set; }
    public int timestamp { get; set; }
    public string data_source { get; set; }
    public Symbols symbols { get; set; }
}