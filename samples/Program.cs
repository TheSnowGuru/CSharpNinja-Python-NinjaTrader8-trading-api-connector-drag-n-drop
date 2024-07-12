using System;
using System.Collections.Generic;
using PyNinjaTrader_API;

namespace test_dll
{
    public class Program
    {

        public static Dictionary<string, string> lookuptable = new Dictionary<string, string>
        {
            {"EURUSD", "EURUSD" },
            {"GBPUSD", "GBPUSD"}
        };

        static void Main(string[] args)
        {

            // declaration of different type of result variables from the DLL
            client.resultDict dict_result = new client.resultDict();
            client.candles candles = new client.candles();
            client.open_orders open_orders = new client.open_orders();
            client.deleted_orders deleted_orders = new client.deleted_orders();
            client.open_positions open_positions = new client.open_positions();
            client.closed_positions closed_positions = new client.closed_positions();

            // create API instance
            PyNinjaTrader_API.client client = new client();

            // connect to MT terminal
            bool result = client.Connect(ip_address:"127.0.0.1", port_number: 1122, _symbols: lookuptable, authorization: "None");

            // show result
            Console.WriteLine(result);

            // check for live connection
            result = client.Check_connection();
            if (result == true)
            {
                client.connected = true;
            }

            // get static account info
            dict_result = client.Get_static_account_info();

            // show some of the result
            Console.WriteLine(dict_result.dict["name"]);

            // get dynamic account info
            dict_result = client.Get_static_account_info();

            // show status of action
            Console.WriteLine(dict_result.status);

            // check for license demo or licensed
            dict_result = client.Check_license();

            // show result
            Console.WriteLine(dict_result.dict["status"]);

            // check for connection, API makes connection with MT terminal for check
            result = client.Check_terminal_server_connection();

            Console.WriteLine(result);

            // check if instrument is tradable
            dict_result = client.Check_trading_allowed(instrument: "GBPUSD");

            // show result
            Console.WriteLine(dict_result.dict["status"]);

            // get instrument information, like min_volume, max_volume, volume_step, digits.....
            dict_result = client.Get_instrument_info(instrument: "EURUSD");

            // show some of the result
            Console.WriteLine(dict_result.dict["digits"]);


            // check if instrument in market watch
            string _instrument = "GBPUSD";
            dict_result = client.Check_instrument(instrument:  _instrument);

            // show result
            Console.WriteLine(dict_result.dict["status"]);

            // get actual bar data
            dict_result = client.Get_actual_bar_info(instrument: _instrument);

            // show result
            if (dict_result.status == true)
            {
                Console.WriteLine(dict_result.dict["open"]);
            }

            // get last x bars/candles data
            candles = client.Get_last_x_bars_from_now(instrument: "EURUSD", timeframe: 5, nbr_of_bars: 500);

            // show result
            if (candles.status == true)
            {
                Console.WriteLine(candles.candle[5].open);
                Console.WriteLine(candles.candle[5].volume);
            }

            // get deleted orders data
            deleted_orders = client.Get_all_deleted_orders();

            // show deleted orders data
            if (deleted_orders.status = true && deleted_orders.order.Count > 0)
            {
                Console.WriteLine(deleted_orders.order[0].instrument);
            }

            // get orders data
            open_orders = client.Get_all_orders();

            // show orders data
            if (open_orders.status == true && open_orders.order.Count > 0)
            {
                Console.WriteLine(open_orders.order[0].instrument);
            }

            // get open positions data
            open_positions = client.Get_all_open_positions();

            // show open positions data
            if (open_positions.status == true && open_positions.open_position.Count > 0)
            {
                Console.WriteLine(open_positions.open_position[0].instrument);
            }

            // get closed positions data
            closed_positions = client.Get_all_closed_positions();

            // show closed  positions data
            if (closed_positions.status == true && closed_positions.closed_position.Count > 0)
            {
                Console.WriteLine(closed_positions.closed_position[0].instrument);
            }



            ///------------------------------------------------------------------------------------------------------
            /// The code below shows how to place orders, close orders/positons and how to change orders / positions
            ///------------------------------------------------------------------------------------------------------

            //int ticket = client.Open_order(instrument = "EURUSD", order_type = "buy_limit", volume = 0.1, open_price = 1.06, slippage = 10, magic_number = 0,
            //                                  stop_loss = 0.0, take_profit = 0.0, comment = "", market = false);

            //int ticket = client.Open_order(order_type: "sell", open_price: 0.0, magic_number: 10000, volume: 0.01);

            //result = client.Set_sl_and_tp_for_position(ticket: 1752230056, stop_loss: 1.06, take_profit: 1.0720);

            //result = client.Close_position_partly_by_ticket(ticket: 1752230879, volume_to_close: 0.02);


            //result = client.Closeby_position_by_ticket(1752230056, opposite_ticket: 1752232134);

            //result = client.Close_position_by_ticket(ticket: 1752230056);


            // disconnect from MT terminal
            result = client.Disconnect();

            // Done
        }
    }
}
