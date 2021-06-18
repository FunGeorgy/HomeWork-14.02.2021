using System;
using System.Text;

namespace Структуры_ДЗ_Калмыков
{
    struct Articule
    {
        public int good_code;
        public string good_name;
        public int price;
        enum ArticuleType
        {
            Chemicals,
            Electronic,
            Food,
            Perfumery
        }
    }

    struct Client
    {
        public int client_code;
        public string[] client_fio;
        public string[] adress;
        public int phone;
        public int sum_of_order;
        public int sum_of_priceorder;
        enum ClientType
        {
           Guest,
           Usual,
           VIP
        }
    }

    struct Request_Item
    {
        public string good;
        public int sum_of_goods;
    }

    struct Request
    {
        public int order_code;
        public string client;
        public DateTime data;
        public string[] list_of_goods;
        public int sum_of_order;
        enum PayType
        {
            cash,
            card,
            bonuscash
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
