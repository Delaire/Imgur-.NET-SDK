# Imgur-.NET-SDK

This is an  .NET SDK for the Imgur API

This is an Beta and is currently working

Appveyor CI:

[![Build status](https://ci.appveyor.com/api/projects/status/3o5g55bkf0ouese0?svg=true)](https://ci.appveyor.com/project/Delaire/imgur-net-sdk)

#Setting up

you first need to get your api key and secret for this work and to initialise it:

    ApiRoot.Instance.Init("XXXXXXXX", "XXXXXX");
           
Here is example of how the api works with the GetEndPointEntityAsync methode:

              	ApiRoot.Instance.GetEndPointEntityAsync<RootElement<Data_Format_we_will_recieve>>(
                                         new Data_to_get()
                                         {
                                             //Data parameters
                                         });


Here is an example for how you can make a call:

            var result = await ApiRoot.Instance.GetEndPointEntityAsync<RootElement<GalleryImage>>(
                new GetGalleryImage	()
                {
                    page = 0,
                    section = Section.hot.ToString(),
                    showViral = true,
                    sort = Sort.top.ToString(),
                    window = WindowsSort.day.ToString(),
                });
                

Here is another example of how to do a Get Random Gallery Image

              	ApiRoot.Instance.GetEndPointEntityAsync<RootElement<GalleryAlbum>>(
                                         new GetRandomGalleryImages()
                                         {
                                             page = pageNumber
                                         });




This API Sdk is used in my personal windows phone imgur app 8gur which can be found here: 
	http://windowsphone.com/s?appid=15913087-9ea1-4f42-92b0-8b2c1c764837




Author:
Damien Delaire

if you wish to help be my guest!


