using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormWarden.Helpers;
using FormWarden.Helpers.Resources;

namespace FormWarden.Helpers
{
    public class UsernameGenerator : IDisposable
    {
        static Random ran = new Random();
        static string[] adjs = null;
        static string[] nouns = null;
        static string[] verbs = null;
        static string[] adverbs = null;
        /// <summary>
        /// Initialize all the words in the DLL
        /// (Naturally made so the generator is fast, You only need to do this once.)
        /// </summary>
        public UsernameGenerator()
        {
            adjs = Resource.Adjectives;
            nouns = Resource.Nouns;
            verbs = Resource.Verbs;
            adverbs = Resource.Adverbs;
        }
        /// <summary>
        /// After initializing the generator, its ready to start!
        /// </summary>
        /// <param name="upperCase">This operation makes the words uppercased.</param>
        /// <param name="allinOne">This operation makes the name spaced out by the two words.</param>
        /// <returns></returns>
        public string GenerateName(bool upperCase, bool allinOne = true)
        {
            string username = "";
            //First we add a switch so we can randomly decide what kind of username we want.
            switch (ran.Next(1, 3))
            {
                case 1:
                    {
                        //Adjetive + Noun
                        //if the username is too small or too long, well keep going.
                        while (username == "" || username.Length < 3 /* MINIMUM VALUE */ || username.Length > 10 /* MAXIMUM VALUE */)
                        {
                            string one = adjs[ran.Next(0, adjs.Length - 1)];
                            while (one == "" || one == " ") one = adjs[ran.Next(0, adjs.Length - 1)];
                            string two = nouns[ran.Next(0, nouns.Length - 1)];
                            while (two == "" || two == " ") two = nouns[ran.Next(0, nouns.Length - 1)];
                            //Pretty self-explanatory <3
                            one = one.ToLower();
                            two = two.ToLower();
                            if (upperCase)
                            {
                                char o = one.Substring(0, 1).ToCharArray()[0];
                                char t = two.Substring(0, 1).ToCharArray()[0];
                                one = one.Remove(0, 1);
                                one = o.ToString().ToUpper() + one;
                                two = two.Remove(0, 1);
                                two = t.ToString().ToUpper() + two;
                            }
                            if (!allinOne)
                            {
                                username = one + " " + two;
                            }
                            else
                            {
                                username = one + two;
                            }
                        }
                        //we found it! lets get out of this mess.
                        break;
                    }
                case 2:
                    {
                        //Verbs + Noun
                        //if the username is too small or too long, well keep going.
                        while (username == "" || username.Length < 3 /* MINIMUM VALUE */ || username.Length > 10 /* MAXIMUM VALUE */)
                        {
                            string one = verbs[ran.Next(0, verbs.Length - 1)];
                            while (one == "" || one == " ") one = verbs[ran.Next(0, verbs.Length - 1)];
                            string two = nouns[ran.Next(0, nouns.Length - 1)];
                            while (two == "" || two == " ") two = nouns[ran.Next(0, nouns.Length - 1)];
                            //Pretty self-explanatory <3
                            one = one.ToLower();
                            two = two.ToLower();
                            if (upperCase)
                            {
                                char o = one.Substring(0, 1).ToCharArray()[0];
                                char t = two.Substring(0, 1).ToCharArray()[0];
                                one = one.Remove(0, 1);
                                one = o.ToString().ToUpper() + one;
                                two = two.Remove(0, 1);
                                two = t.ToString().ToUpper() + two;
                            }
                            if (!allinOne)
                            {
                                username = one + " " + two;
                            }
                            else
                            {
                                username = one + two;
                            }
                        }
                        //we found it! lets get out of this mess.
                        break;
                    }
                case 3:
                    {
                        //Adverb + Noun
                        //if the username is too small or too long, well keep going.
                        while (username == "" || username.Length < 3 /* MINIMUM VALUE */ || username.Length > 10 /* MAXIMUM VALUE */)
                        {
                            string one = adverbs[ran.Next(0, adverbs.Length - 1)];
                            while (one == "" || one == " ") one = adverbs[ran.Next(0, adverbs.Length - 1)];
                            string two = nouns[ran.Next(0, nouns.Length - 1)];
                            while (two == "" || two == " ") two = nouns[ran.Next(0, nouns.Length - 1)];
                            //Pretty self-explanatory <3
                            one = one.ToLower();
                            two = two.ToLower();
                            if (upperCase)
                            {
                                char o = one.Substring(0, 1).ToCharArray()[0];
                                char t = two.Substring(0, 1).ToCharArray()[0];
                                one = one.Remove(0, 1);
                                one = o.ToString().ToUpper() + one;
                                two = two.Remove(0, 1);
                                two = t.ToString().ToUpper() + two;
                            }
                            if (!allinOne)
                            {
                                username = one + " " + two;
                            }
                            else
                            {
                                username = one + two;
                            }
                        }
                        //we found it! lets get out of this mess.
                        break;
                    }
            }
            //Replace unwanted chars
            foreach (char c in username)
            {
                string valuablechars = allinOne == true ? "abcdefghijklmnopqrstuvwxyz" : "abcdefghijklmnopqrstuvwxyz ";
                if (!valuablechars.Contains(c.ToString().ToLower()))
                {
                    username = username.Replace(c.ToString(), "");
                }
            }
            return username;
        }
        void IDisposable.Dispose()
        {
            adjs = null;
            nouns = null;
            verbs = null;
            adverbs = null;
        }
    }
}