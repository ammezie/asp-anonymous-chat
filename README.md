# ASP.NET Public Anonymous Chat

Build a public anonymous chatroom with .NET, jQuery and Pusher. Follow the tutorial [https://pusher.com/tutorials/anonymous-chat-aspnet/](https://pusher.com/tutorials/anonymous-chat-aspnet/)

### Getting Started

Clone the project repository by running the command below if you use SSH

```
git clone git@github.com:ammezie/asp-anonymous-chat.git
```

If you use https, use this instead

```
git clone https://github.com/ammezie/asp-anonymous-chat.git
```

After cloning, open the `pusherasp.sln` file in visual studio.

### Prerequisites

#### Setup Pusher

If you don't have one already, create a free Pusher account at https://pusher.com/signup then login to your dashboard and create an app. 


Then fill in your Pusher app credentials in your `pusherasp\Controllers\HomeController` file by replacing this line with your appid, appkey and app secret respectively:

```
var pusher = new Pusher("PUSHER_APP_ID", "PUSHER_APP_KEY", "PUSHER_APP_SECRET", options);
```

Also, remember to fill in the your secret key and app cluster in your `pusherasp\Views\Home\Index.cshtml` file by updating this line:

```
var pusher = new Pusher('PUSHER_APP_KEY', {cluster: 'XXX_CLUSTER'});
```

And finally, start the application by clicking the debug button on your visual studio.

## Built With

* [Pusher](https://pusher.com/) - APIs to enable devs building realtime features
* [C# ASP.NET](https://www.asp.net/) - An open source web framework for building modern web apps and services with .NET
* [jQuery](https://jquery.com) - A fast, small, and feature-rich JavaScript library

## Acknowledgments

* [Bootsnipp chat snippet](http://bootsnipp.com/snippets/featured/collapsible-chat-widget)
