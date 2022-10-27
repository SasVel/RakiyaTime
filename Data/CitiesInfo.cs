using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakiyaTime.Data
{
    public static class CitiesInfo
    {
        public static Dictionary<int, string[]> cities 
            = new Dictionary<int, string[]>()
            {
                { 0, new string[] 
                        { 
                            "Timbuktu, Mali",
                            "Danmarkshavn, Greenland",
                            "Dakar, Senegal",
                            "Lomé, Togo",
                        }
                }, 
                { 1, new string[] 
                        {
                            "Bangui, Central African Republic",
                            "Douglas, Isle of Man",
                            "Cardiff, United Kingdom",
                            "London, United Kingdom",

                        }
                }, 
                { 2, new string[] 
                        {
                            "Sarajevo, Bosnia-Herzegovina",
                            "Budapest, Hungary",
                            "Berlin, Germany",
                            "Luxembourg",
                            "Paris, France",
                            "Oslo, Norway",
                            "Stockholm, Sweden",
                        }
                }, 
                { 3, new string[] 
                        {
                            "Antananarivo, Madagascar",
                            "Moscow, Russia",
                            "Sofia, Bulgaria",
                            "Kyiv, Ukraine",
                            "Rovaniemi, Finland",
                            "Jerusalem, Israel"
                        } 
                }, 
                { 4, new string[] 
                        {
                            "Abu Dhabi, United Arab Emirates",
                            "Samara, Russia",
                            "Yerevan, Armenia",
                            "Dubai, United Arab Emirates"
                        } 
                }, 
                { 5, new string[] 
                        {
                            "Male, Maldives",
                            "Tashkent, Uzbekistan",
                            "Yekaterinburg, Russia",
                            "Oral, Kazakhstan"
                        } 
                }, 
                { 6, new string[] 
                        {
                            "Almaty, Kazakhstan",
                            "Bishkek, Kyrgyzstan",
                            "Omsk, Russia",
                            "Thimphu, Bhutan"
                        } 
                }, 
                { 7, new string[] 
                        {
                            "Hovd, Mongolia",
                            "Krasnoyarsk, Russia",
                            "Novosibirsk, Russia",
                            "Bangkok, Thailand",
                            "Pontianak, Indonesia"
                        } 
                }, 
                { 8, new string[] 
                        {
                            "Beijing, China",
                            "Perth, Australia",
                            "Irkutsk, Russia",
                            "Ulaanbaatar, Mongolia",
                            "Shanghai, China"
                        } 
                }, 
                { 9, new string[] 
                        {
                            "Manokwari, Indonesia",
                            "Chita, Russia",
                            "Yakutsk, Russia",
                            "Tiksi, Russia"
                        } 
                }, 
                { 10, new string[] 
                        {
                            "Cairns, Australia",
                            "Brisbane, Australia",
                            "Port Moresby, Papua New Guinea",
                            "Vladivostok, Russia"
                        }
                }, 
                { 11, new string[] 
                        {
                            "Honiara, Solomon Islands",
                            "Srednekolymsk, Russia",
                            "Yuzhno-Sakhalinsk, Russia",
                            "Melbourne, Australia",
                            "Canberra, Australia"
                        } 
                }, 
                { 12, new string[] 
                        {
                            "Suva, Fiji",
                            "Chatham Islands, New Zealand",
                            "Tarawa, Kiribati",
                            "Wake Island, US Minor Islands",
                            "Nuku'alofa, Tonga"
                        } 
                },
                { -11, new string[]
                        {
                            "Alofi, Niue",
                            "Jarvis Island",
                            "Kingman Reef",
                            "Palmyra Atoll",
                        }
                },
                { -10, new string[]
                        {
                            "Rarotonga, Cook Islands",
                            "Honolulu, Hawaii",
                            "Papeete, Tahiti",
                        }
                },
                { -9, new string[]
                        {
                            "Hall Island Alaska",
                            "Aleutian Islands, Alaska",
                            "Gambier Islands"
                        }
                },
                { -8, new string[]
                        {
                            "Anchorage, Alaska",
                            "Fairbanks, Alaska",
                            "Unalaska, Alaska",
                            "Idaho",
                            "Oregon",
                            "Nevada"
                        }
                },
                { -7, new string[]
                        {
                            "Hermosillo, Mexico",
                            "Phoenix, Arizona",
                            "Las Vegas, Nevada",
                            "San Francisco, California"
                        }
                },
                { -6, new string[]
                        {
                            "Denver, Colorado",
                            "Salt Lake City, Utah",
                            "Edmonton, Canada",
                            "Inuvik, Canada"
                        }
                },
                { -5, new string[]
                        {
                            "Bogota, Colombia",
                            "Lima, Peru",
                            "Quito, Ecuador",
                            "Winnipeg, Canada",
                            "Dallas, USA",
                            "Mexico City, Mexico"
                        }
                },
                { -4, new string[]
                        {
                            "Sucre, Bolivia",
                            "La Paz, Bolivia",
                            "Rio Branco, Brazil",
                            "Ottawa, Canada",
                            "New York, USA"
                        }
                },
                { -3, new string[]
                        {
                            "Rio de Janeiro, Brazil",
                            "Santiago, Chile",
                            "Montevideo, Uruguay",
                            "Happy Valley-Goose Bay, Canada"
                        }
                },
                { -2, new string[]
                        {
                            "Nuuk, Greenland",
                            "Kangerlussuaq, Greenland",
                            "Qaanaaq, Greenland",
                            "St. John's, Canada"
                        }
                },
                { -1, new string[]
                        {
                            "Praia, Cabo Verde",
                            "Azores islands, Portugal",
                            "Cape Verde",
                            "Neerlerit Inaat, Greenland"
                        }
                },
            };

        public static List<string> GetCitiesByUTC(int utcNum)
        {
            List<string> extractedCities 
                = cities.Where(c => c.Key == utcNum).First().Value.ToList();
            List<string> res = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                var rand = new Random();
                var city = extractedCities.ElementAt(rand.Next(extractedCities.Count()));
                extractedCities.Remove(city);
                res.Add(city);
            }
            
            
            return res;
        }

    }
}
