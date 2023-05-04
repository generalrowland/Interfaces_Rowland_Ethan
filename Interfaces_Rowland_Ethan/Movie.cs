using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Rowland_Ethan
{
    class Movie : IGenre
    {
        //
        public string Esrb { get; set; }
        public string Genre { get; set; } //
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting. SSssssshhhhh!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rate {Esrb}!";
        }
    }
}
