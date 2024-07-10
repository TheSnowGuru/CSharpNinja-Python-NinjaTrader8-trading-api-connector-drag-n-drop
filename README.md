## PyNinjaTrader_API - Drag & Drop C# Connector(DLL) for strategies coded in C# in combination with MT4/5 brokers.

The PyNinjaTrader_API is a connection/interface between C# strategy(Visual Studio, VS code, NT8,...) and a MT4/5 terminal. In priciple for all C# coding as long as external DDL's can be imported.
The functionality is an anology to our wel known Pytrader_API used by many user strategies coded in python.
Besides the DLL an EA is needed for MT4 and MT5 terminal. These are also part of the system.
The demo version has full functionality for the following instruments: EURUSD, AUDCHF, NZDCHF, GBPNZD and USDCAD. Dax is added as index instrument in the demo.
The functionality is documented in an .pdf file.
![image](https://github.com/TheSnowGuru/PyNinjaTrader-python-NinjaTrader8-trading-api-connector-drag-n-drop/assets/5313475/a8ea44f7-762a-40db-b25c-6676dce57580)

The PythonNinja ecosystem consists of a C# DLL and a NinjaTrader 8 C# script. 
For licensing, an indicator is used. 
Documentation for connecting NinjaTrader 8 with MT4/5 terminal using a simple drag and drop indicator and an EA.
A fully suited solution that is fully tested, fast, and efficient.

The communication between the NT8 strategy script and the MT4/5 terminal is based on sockets.
The strategy acts as the server, and the Python script is the client.
It is always query (function/Python script) and output (data/server).
The strategy does not need to run on the same computer as the Python script.
On our GitHub link, you will find the Python script, the strategies, full documentation, and a PyNinjaTrader example script showing how to call the functions.
For questions, we also have a Discord channel.
In the demo (without the licensing indicator), you have full functionality, but for a limited number of instruments 
(EURUSD, AUDCHF, NZDCHF, GBPNZD, and USDCAD).

[![Join our Discord](https://github.com/TheSnowGuru/PyTrader-python-mt4-mt5-trading-api-connector-drag-n-drop/blob/master/join.png)](https://discord.gg/wRMUNP8ERa)

Check versions: Python Ninja 

# Python NinjaTrader 8 Connector
Easier than ever before! Connecting NinjaTrader 8 with Pythonic strategies using this simple drag and drop connector has never been so easy!
A full & fast solution tested with real trading. 
Amazing capabilities like downloading bar data & creating a live feed for your strategies with few line of code. 

## Drag & Drop Python Connector for NinjaTrader 8 
## Growing list of features:
* Python login to NinjaTrader 8 Terminal
* Python Connection keep-alive function
* Get NinjaTrader 8 Account Info → Python client
* Python Client Open New Orders → NinjaTrader 8
 (Verify the sending, and verifying the receiving of the order in NinjaTrader 8)
* Python Client can Change (take profit, stop loss)/Cancel/Open Orders → NinjaTrader 8
* Python Close/Partly Close Positions → NinjaTrader 8
* NinjaTrader 8 Execution info → Python client
* NinjaTrader 8 → Python Get all Open orders & Positions
* NinjaTrader 8 → Python Get static account information
* NinjaTrader 8 → Python Get dynamic account info like [balance, equity, margin, free margins]
* NinjaTrader 8 → Python Get instrument information [pip value, max lot, tick size, tick value]
* NinjaTrader 8 → Python Get last tick data [date, bid, ask, volume]
* NinjaTrader 8 → Python Get bar data [date, open, low, high, close, volume]
* NinjaTrader 8 → Python Get last X ticks array [date, bid, ask, last, volume]
* NinjaTrader 8 → Python Get last X bars array [date, open, low, high, close, volume]
* NinjaTrader 8 → Python Get indicator data from NinjaTrader 8 to your script - coming soon!

## NinjaTrader 8 installation flow:
![Installation flow](https://github.com/TheSnowGuru/PythonNinja-Python-NinjaTrader8-trading-api-connector-drag-n-drop/blob/main/Ninja_ea_install.png  "Installation flow")

## Documentation
See the documentation for NinjaTrader 8 [here](#)

## Get the strategy working for all instruments:
## NinjaTrader 8 Python ==> Get FULL Version [here](https://www.mql5.com/en/market/product/118213)
