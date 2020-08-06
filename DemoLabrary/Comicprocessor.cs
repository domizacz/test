﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLabrary
{
    public class Comicprocessor
    {
        public int MaxComicNumber { get; set; }

        public async Task<ComicModel> LoadComic(int comicNumber = 0)
        {
            string url = "";
            if (comicNumber > 0)
            {
                url = $"https://xkcd.com/{ comicNumber} /info.0.json";

            }
            else
            { 
                url = "https://xkcd.com/info.0.json";
            
            }

            using (HttpResponseMessage response = await ApiHelper.APiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();
                    if(comicNumber==0)
                    {
                        MaxComicNumber = comic.Num;
                    }

                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }
    }
}
