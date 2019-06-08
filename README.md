# oanda_dotnet
A .NET API wrapper for Oanda's Restv20 & Streaming APIs. Documentation for both API's can be found here: http://developer.oanda.com/rest-live-v20/introduction/ 

## Unit Testing Configuration
In order to run the unit tests you'll need to set up an api key user secret on your local machine.
1. In a shell cd into the oanda_dotnet.test project directory.
2. Enter command: `dotnet user-secrets set Oanda:ApiKey ${YOUR-API-KEY}`
3. Enter command: `dotnet user-secrets set Oanda:AccountId ${YOUR-ACCOUNT-ID}` (this must be an Oanda testing account)
