using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{
    public static void Test()
    {
        Trie tr = new Trie();
        tr.Insert(apple);
        bool b1 = tr.Search(apple);
        bool b2 = tr.StartsWith(app);

        Console.WriteLine(b1);
        Console.WriteLine(b2);
    }

    public class Trie
    {        

        /** Initialize your data structure here. */
        TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode cur = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!cur.dict.ContainsKey(word[i]))
                {
                    cur.dict[word[i]] = new TrieNode();
                }

                cur = cur.dict[word[i]];
            }
            cur.EndWord = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode cur = root;

            for (int i = 0; i < word.Length; i++)
            {
                if (!cur.dict.ContainsKey(word[i]))
                {
                    return false;
                }

                cur = cur.dict[word[i]];
            }

            return cur.EndWord;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode cur = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (!cur.dict.ContainsKey(prefix[i]))
                {
                    return false;
                }
                cur = cur.dict[prefix[i]];
            }
            return true;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> dict;
        public bool EndWord;

        public TrieNode()
        {
            dict = new Dictionary<char, TrieNode>();
        }
    }
}

