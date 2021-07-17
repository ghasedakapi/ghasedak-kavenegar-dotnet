
# .Net migration library from Kavenegar to Ghasedak

# <a href="https://ghasedak.io/kavenegar">migration guide</a>

see the migration guide

# Installation
  
## Nuget Package Manager
   Install-Package Ghasedak.Kavenegar.Net -Version 1.0.1
## .NET CLI 
   dotnet add package Ghasedak.Kavenegar.Net --version 1.0.1

## Usage
Send Simple

```c#
try
{
	Ghasedak.Kavenegar.KavenegarApi api = new Ghasedak.Kavenegar.KavenegarApi("Your Api Key");
	var result = api.Send("SenderLine", "Your Receptor", "مهاجرت از کاوه نگار به قاصدک");
	
	Console.Write(result.Messageid.ToString());
  
}
catch (Ghasedak.Kavenegar.Exceptions.ApiException ex) 
{
	// در صورتی که خروجی وب سرویس 200 نباشد این خطارخ می دهد.
	Console.Write("Message : " + ex.Message);
}
catch (Ghasedak.Kavenegar.Exceptions.HttpException ex) 
{
	// در زمانی که مشکلی در برقرای ارتباط با وب سرویس وجود داشته باشد این خطا رخ می دهد
	Console.Write("Message : " + ex.Message);
}
```
 
<div dir='rtl'>
	
## راهنما


### همکاری
پیشنهادات، مشکلات احتمالی و یا سرویس های جدید مورد نیاز خود را با در میان بگذارید <a href="mailto:support@ghasedak.me?Subject=Kavenegar-SDK" target="_top">support@ghasedak.me</a>
  

### معرفی سرویس قاصدک

قاصدک وب سرویس ارسال و دریافت پیامک و تماس صوتی است که به راحتی میتوانید از آن استفاده نمایید.
 
### مستندات

برای مشاهده اطلاعات کامل مستندات وب سرویس به صفحه [مستندات وب سرویس](https://ghasedak.me/developers) مراجعه نمایید.

 
### اطالاعات بیشتر
برای مطالعه بیشتر به صفحه[ مهاجرت از کاوه نگار به قاصدک ](https://ghasedak.me/kavenegar) مراجعه نمایید.

##
![https://ghasedak.me](https://ghasedak.me/img/logo.png)		

[https://ghasedak.me](https://ghasedak.me)	

</div>


