# About
## Description
BlackFridaySniffer is a project I decided building it since last BlackFriday, when I lost really good prices because I wasn't able to be browsing and updating pages to get the prices I wanted to.

With BlackFridaySniffer, you'll be able to set products you want, specify the website url where you want to get it from and the xpath of the price within the page (which I'll show later how it's done), the maximum price you're willing to pay, and the desired one, using ProductLoader.

After that running the service BlackFridaySniffer, it will every 5 minutes, open a new Google Web Driver, and browse the website looking for prices, check if there as low as expected and message you the ones that are.

## Thumbnail

![thumbnail](thumbnail.gif)

# Setup
## Prerequisites
1. **Twilio Account**: Its service will be used to send WhatsApp messages with the best prices.
2. **.Net Core**: Basic knowledge with C#. A bit more if you're willing to change the way something works.
3. **MySQL**: Database installed and configured (No database support soon).

## Running locally

Clone this project or download it. It's recommended to install [GitHub desktop](https://desktop.github.com/).

    git clone https://github.com/allmomoro088/BlackFridaySniffer.git

**Visual Studio**:

Load the project on Visual Studio Community or superior.
Go to **appsettings.json** and fill the following fields according to your environment:

**ConnectionStrings**:
- mysql: `YOUR_SERVER` to your local MySQL server and its instance
- mysql: `YOUR_USER` to your MySQL user
- mysql: `YOUR_PASSWORD` to your MySQL user's password

**TwilioSettings**:

After setting up your Twilio account and joining the sandbox, you will have all the required information to fill this section.

- SenderPhone: `YOUR_SENDER_NUMBER` the phone number provided during sandbox setup. To send messages through WhatsApp, keep the `whatsapp:` before the number.
- ReceiverPhone: `YOUR_RECEIVER_NUMBER` your phone number, the one which will receive the message with prices.  To send messages through WhatsApp, keep the `whatsapp:` before the number.
- AccountSid: `YOUR_ACCOUNT_SID` your account sid, you can find that on your Twilio Account Console page.
- AuthToken: `YOUR_AUTH_TOKEN` your auth token, can be found in the same page as account sid.

**DbContext Migration**:

Open the Package Manager Console and execute the following command to create the database and tables within your MySQL server:

    Update-Database

By now you'll be able to start the service, by running it through Visual Studio, or building it and running its .exe file.

**Managing Products**:

To add or remove products from your database, you'll need to start **ProductLoader** project. It consumes BlackFridaySniffer **appsettings.json** file, so there's no setup step needed.

To add, just launch **ProductLoader**, and there fill the fields with product name, it's url on the website you want to get it from, the xpath where the price is located (which for that you'll need to, go to the product's url, right click the price and click on Inspect, right the price HTML element, and go to Copy, Copy Xpath, then paste that information on Xpath field), maximum price and the desired one, and click Insert.

To remove, click on the product on the list, then click on Remove.