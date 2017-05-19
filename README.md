# ASP.NET Public Anonymous Chat 
Build a public anonymous chatroom with .NET and Pusher

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

### Setup Pusher

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
