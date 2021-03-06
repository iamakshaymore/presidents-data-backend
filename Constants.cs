﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7
{
    public class Constants
    {
        public const string PRESIDENT_DATA_JSON_KEY= "PresidentData";
        public const string PPRESIDENT_BIRTH_PLACE_KEY= "Birthplace";
        public const string PRESIDENT_BIRTH_DAY_KEY = "Birthday";
        public const string PPRESIDENT_DEATH_DAY_KEY = "Death day";
        public const string PPRESIDENT_DEATH_PLACE_KEY = "Death place";
        public const string PPRESIDENT_NAME_KEY = "President";


        public const string PRESIDENT_JSON = @"{  
   ""PresidentData"":[  
   {
      ""President"": ""George Washington"",
      ""Birthday"": ""1732-2-22"",
      ""Birthplace"": ""Westmoreland Co., Va."",
      ""Death day"": ""1799-12-14"",
      ""Death place"": ""Mount Vernon, Va.""
   },
   {
      ""President"": ""John Adams"",
      ""Birthday"": ""1735-10-30"",
      ""Birthplace"": ""Quincy, Mass."",
      ""Death day"": ""1826-7-4"",
      ""Death place"": ""Quincy, Mass.""
   },
   {
      ""President"": ""Thomas Jefferson"",
      ""Birthday"": ""1743-4-13"",
      ""Birthplace"": ""Albemarle Co., Va."",
      ""Death day"": ""1826-7-4"",
      ""Death place"": ""Albemarle Co., Va.""
   },
   {
      ""President"": ""James Madison"",
      ""Birthday"": ""1751-3-16"",
      ""Birthplace"": ""Port Conway, Va."",
      ""Death day"": ""1836-6-28"",
      ""Death place"": ""Orange Co., Va.""
   },
   {
      ""President"": ""James Monroe"",
      ""Birthday"": ""1758-4-28"",
      ""Birthplace"": ""Westmoreland Co., Va."",
      ""Death day"": ""1831-7-4"",
      ""Death place"": ""New York, New York""
   },
   {
      ""President"": ""John Quincy Adams"",
      ""Birthday"": ""1767-7-11"",
      ""Birthplace"": ""Quincy, Mass."",
      ""Death day"": ""1848-2-23"",
      ""Death place"": ""Washington, D.C.""
   },
   {
      ""President"": ""Andrew Jackson"",
      ""Birthday"": ""1767-3-15"",
      ""Birthplace"": ""Waxhaws, No./So. Carolina"",
      ""Death day"": ""1845-6-8"",
      ""Death place"": ""Nashville, Tennessee""
   },
   {
      ""President"": ""Martin Van Buren"",
      ""Birthday"": ""1782-12-5"",
      ""Birthplace"": ""Kinderhook, New York"",
      ""Death day"": ""1862-7-24"",
      ""Death place"": ""Kinderhook, New York""
   },
   {
      ""President"": ""William Henry Harrison"",
      ""Birthday"": ""1773-2-9"",
      ""Birthplace"": ""Charles City Co., Va."",
      ""Death day"": ""1841-4-4"",
      ""Death place"": ""Washington, D.C.""
   },
   {
      ""President"": ""John Tyler"",
      ""Birthday"": ""1790-3-29"",
      ""Birthplace"": ""Charles City Co., Va."",
      ""Death day"": ""1862-1-18"",
      ""Death place"": ""Richmond, Va.""
   },
   {
      ""President"": ""James K. Polk"",
      ""Birthday"": ""1795-11-2"",
      ""Birthplace"": ""Mecklenburg Co., N.C."",
      ""Death day"": ""1849-6-15"",
      ""Death place"": ""Nashville, Tennessee""
   },
   {
      ""President"": ""Zachary Taylor"",
      ""Birthday"": ""1784-11-24"",
      ""Birthplace"": ""Orange County, Va."",
      ""Death day"": ""1850-7-9"",
      ""Death place"": ""Washington, D.C""
   },
   {
      ""President"": ""Millard Fillmore"",
      ""Birthday"": ""1800-1-7"",
      ""Birthplace"": ""Cayuga Co., New York"",
      ""Death day"": ""1874-3-8"",
      ""Death place"": ""Buffalo, New York""
   },
   {
      ""President"": ""Franklin Pierce"",
      ""Birthday"": ""1804-11-23"",
      ""Birthplace"": ""Hillsborough, N.H."",
      ""Death day"": ""1869-10-8"",
      ""Death place"": ""Concord, New Hamp.""
   },
   {
      ""President"": ""James Buchanan"",
      ""Birthday"": ""1791-4-23"",
      ""Birthplace"": ""Cove Gap, Pa."",
      ""Death day"": ""1868-6-1"",
      ""Death place"": ""Lancaster, Pa.""
   },
   {
      ""President"": ""Abraham Lincoln"",
      ""Birthday"": ""1809-2-12"",
      ""Birthplace"": ""LaRue Co., Kentucky"",
      ""Death day"": ""1865-4-15"",
      ""Death place"": ""Washington, D.C.""
   },
   {
      ""President"": ""Andrew Johnson"",
      ""Birthday"": ""1808-12-29"",
      ""Birthplace"": ""Raleigh, North Carolina"",
      ""Death day"": ""1875-7-31"",
      ""Death place"": ""Elizabethton, Tenn.""
   },
   {
      ""President"": ""Ulysses S. Grant"",
      ""Birthday"": ""1822-4-27"",
      ""Birthplace"": ""Point Pleasant, Ohio"",
      ""Death day"": ""1885-7-23"",
      ""Death place"": ""Wilton, New York""
   },
   {
      ""President"": ""Rutherford B. Hayes"",
      ""Birthday"": ""1822-10-4"",
      ""Birthplace"": ""Delaware, Ohio"",
      ""Death day"": ""1893-1-17"",
      ""Death place"": ""Fremont, Ohio""
   },
   {
      ""President"": ""James A. Garfield"",
      ""Birthday"": ""1831-11-19"",
      ""Birthplace"": ""Cuyahoga Co., Ohio"",
      ""Death day"": ""1881-9-19"",
      ""Death place"": ""Elberon, New Jersey""
   },
   {
      ""President"": ""Chester Arthur"",
      ""Birthday"": ""1829-10-5"",
      ""Birthplace"": ""Fairfield, Vermont"",
      ""Death day"": ""1886-11-18"",
      ""Death place"": ""New York, New York""
   },
   {
      ""President"": ""Grover Cleveland"",
      ""Birthday"": ""1837-3-18"",
      ""Birthplace"": ""Caldwell, New Jersey"",
      ""Death day"": ""1908-6-24"",
      ""Death place"": ""Princeton, New Jersey""
   },
   {
      ""President"": ""Benjamin Harrison"",
      ""Birthday"": ""1833-8-20"",
      ""Birthplace"": ""North Bend, Ohio"",
      ""Death day"": ""1901-3-13"",
      ""Death place"": ""Indianapolis, Indiana""
   },
   {
      ""President"": ""William McKinley"",
      ""Birthday"": ""1843-1-29"",
      ""Birthplace"": ""Niles, Ohio"",
      ""Death day"": ""1901-9-14"",
      ""Death place"": ""Buffalo, New York""
   },
   {
      ""President"": ""Theodore Roosevelt"",
      ""Birthday"": ""1858-10-27"",
      ""Birthplace"": ""New York, New York"",
      ""Death day"": ""1919-1-6"",
      ""Death place"": ""Oyster Bay, New York""
   },
   {
      ""President"": ""William Howard Taft"",
      ""Birthday"": ""1857-9-15"",
      ""Birthplace"": ""Cincinnati, Ohio"",
      ""Death day"": ""1930-3-8"",
      ""Death place"": ""Washington, D.C.""
   },
   {
      ""President"": ""Woodrow Wilson"",
      ""Birthday"": ""1856-12-28"",
      ""Birthplace"": ""Staunton, Virginia"",
      ""Death day"": ""1924-2-3"",
      ""Death place"": ""Washington, D.C.""
   },
   {
      ""President"": ""Warren G. Harding"",
      ""Birthday"": ""1865-11-2"",
      ""Birthplace"": ""Morrow County, Ohio"",
      ""Death day"": ""1923-8-2"",
      ""Death place"": ""San Francisco, Cal.""
   },
   {
      ""President"": ""Calvin Coolidge"",
      ""Birthday"": ""1872-7-4"",
      ""Birthplace"": ""Plymouth, Vermont"",
      ""Death day"": ""1933-1-5"",
      ""Death place"": ""Northampton, Mass.""
   },
   {
      ""President"": ""Herbert Hoover"",
      ""Birthday"": ""1874-8-10"",
      ""Birthplace"": ""West Branch, Iowa"",
      ""Death day"": ""1964-10-20"",
      ""Death place"": ""New York, New York""
   },
   {
      ""President"": ""Franklin Roosevelt"",
      ""Birthday"": ""1882-1-30"",
      ""Birthplace"": ""Hyde Park, New York"",
      ""Death day"": ""1945-4-12"",
      ""Death place"": ""Warm Springs, Georgia""
   },
   {
      ""President"": ""Harry S. Truman"",
      ""Birthday"": ""1884-5-8"",
      ""Birthplace"": ""Lamar, Missouri"",
      ""Death day"": ""1972-12-26"",
      ""Death place"": ""Kansas City, Missouri""
   },
   {
      ""President"": ""Dwight Eisenhower"",
      ""Birthday"": ""1890-10-14"",
      ""Birthplace"": ""Denison, Texas"",
      ""Death day"": ""1969-3-28"",
      ""Death place"": ""Washington, D.C.""
   },
   {
      ""President"": ""John F. Kennedy"",
      ""Birthday"": ""1917-5-29"",
      ""Birthplace"": ""Brookline, Mass."",
      ""Death day"": ""1963-11-22"",
      ""Death place"": ""Dallas, Texas""
   },
   {
      ""President"": ""Lyndon B. Johnson"",
      ""Birthday"": ""1908-8-27"",
      ""Birthplace"": ""Gillespie Co., Texas"",
      ""Death day"": ""1973-1-22"",
      ""Death place"": ""Gillespie Co., Texas""
   },
   {
      ""President"": ""Richard Nixon"",
      ""Birthday"": ""1913-1-9"",
      ""Birthplace"": ""Yorba Linda, Cal."",
      ""Death day"": ""1994-4-22"",
      ""Death place"": ""New York, New York""
   },
   {
      ""President"": ""Gerald Ford"",
      ""Birthday"": ""1913-7-14"",
      ""Birthplace"": ""Omaha, Nebraska"",
      ""Death day"": ""2006-12-26"",
      ""Death place"": ""Rancho Mirage, Cal.""
   },
   {
      ""President"": ""Jimmy Carter"",
      ""Birthday"": ""1924-10-1"",
      ""Birthplace"": ""Plains, Georgia"",
      ""Death day"": """",
      ""Death place"": """"
   },
   {
      ""President"": ""Ronald Reagan"",
      ""Birthday"": ""1911-2-6"",
      ""Birthplace"": ""Tampico, Illinois"",
      ""Death day"": ""2004-6-5"",
      ""Death place"": ""Los Angeles, Cal.""
   },
   {
      ""President"": ""George Bush"",
      ""Birthday"": ""1924-6-12"",
      ""Birthplace"": ""Milton, Mass."",
      ""Death day"": """",
      ""Death place"": """"
   },
   {
      ""President"": ""Bill Clinton"",
      ""Birthday"": ""1946-8-19"",
      ""Birthplace"": ""Hope, Arkansas"",
      ""Death day"": """",
      ""Death place"": """"
   },
   {
      ""President"": ""George W. Bush"",
      ""Birthday"": ""1646-7-6"",
      ""Birthplace"": ""New Haven, Conn."",
      ""Death day"": """",
      ""Death place"": """"
   },
   {
      ""President"": ""Barack Obama"",
      ""Birthday"": ""1961-8-4"",
      ""Birthplace"": ""Honolulu, Hawaii"",
      ""Death day"": """",
      ""Death place"": """"
   },
    {
      ""President"": ""Donald Trump"",
      ""Birthday"": ""1946-6-14"",
      ""Birthplace"": ""New York, New York"",
      ""Death day"": """",
      ""Death place"": """"
    }
]
}";
    }
}