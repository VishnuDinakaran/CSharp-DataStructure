<Query Kind="Program">
  <IncludeLinqToSql>true</IncludeLinqToSql>
</Query>

void Main()
{
    HashSet<int> h = new HashSet<int>();
    HashSet<int> h1 = new HashSet<int>(h);
	
    
	StringBuilder s = new StringBuilder();	s.Clear();
	s.Append('A');
	s.Append('B');
	s.Append('C');
	Console.WriteLine($" S => {s.ToString()}");
	
	s.Remove(s.Length-1, 1);
	
	Console.WriteLine($" S => {s.ToString()}");
	
	Solution.TrieNode root = new Solution.TrieNode('*');
	//root.AddNode("Vishnu");
	//root.AddNode("Vignajith");
	//root.AddNode("Vidhula");
	//root.AddNode("Vidla");
	
	root.AddNode("Vid");
	root.AddNode("Vidula");
	root.AddNode("Vis");
	//root.AddNode("Vish");
	
	//root.ToString();
	//Console.WriteLine("  ");
	//root.DeleteWord("Vid");
	//root.ToString();
	
	string[] sArr = new string[] {"aaaaaaaaaa","aaaaaaaaab","aaaaaaaaac","aaaaaaaaad","aaaaaaaaae","aaaaaaaaaf","aaaaaaaaag","aaaaaaaaah","aaaaaaaaai","aaaaaaaaaj","aaaaaaaaak","aaaaaaaaal","aaaaaaaaam","aaaaaaaaan","aaaaaaaaao","aaaaaaaaap","aaaaaaaaaq","aaaaaaaaar","aaaaaaaaas","aaaaaaaaat","aaaaaaaaau","aaaaaaaaav","aaaaaaaaaw","aaaaaaaaax","aaaaaaaaay","aaaaaaaaaz","aaaaaaaaba","aaaaaaaabb","aaaaaaaabc","aaaaaaaabd","aaaaaaaabe","aaaaaaaabf","aaaaaaaabg","aaaaaaaabh","aaaaaaaabi","aaaaaaaabj","aaaaaaaabk","aaaaaaaabl","aaaaaaaabm","aaaaaaaabn","aaaaaaaabo","aaaaaaaabp","aaaaaaaabq","aaaaaaaabr","aaaaaaaabs","aaaaaaaabt","aaaaaaaabu","aaaaaaaabv","aaaaaaaabw","aaaaaaaabx","aaaaaaaaby","aaaaaaaabz","aaaaaaaaca","aaaaaaaacb","aaaaaaaacc","aaaaaaaacd","aaaaaaaace","aaaaaaaacf","aaaaaaaacg","aaaaaaaach","aaaaaaaaci","aaaaaaaacj","aaaaaaaack","aaaaaaaacl","aaaaaaaacm","aaaaaaaacn","aaaaaaaaco","aaaaaaaacp","aaaaaaaacq","aaaaaaaacr","aaaaaaaacs","aaaaaaaact","aaaaaaaacu","aaaaaaaacv","aaaaaaaacw","aaaaaaaacx","aaaaaaaacy","aaaaaaaacz","aaaaaaaada","aaaaaaaadb","aaaaaaaadc","aaaaaaaadd","aaaaaaaade","aaaaaaaadf","aaaaaaaadg","aaaaaaaadh","aaaaaaaadi","aaaaaaaadj","aaaaaaaadk","aaaaaaaadl","aaaaaaaadm","aaaaaaaadn","aaaaaaaado","aaaaaaaadp","aaaaaaaadq","aaaaaaaadr","aaaaaaaads","aaaaaaaadt","aaaaaaaadu","aaaaaaaadv","aaaaaaaadw","aaaaaaaadx","aaaaaaaady","aaaaaaaadz","aaaaaaaaea","aaaaaaaaeb","aaaaaaaaec","aaaaaaaaed","aaaaaaaaee","aaaaaaaaef","aaaaaaaaeg","aaaaaaaaeh","aaaaaaaaei","aaaaaaaaej","aaaaaaaaek","aaaaaaaael","aaaaaaaaem","aaaaaaaaen","aaaaaaaaeo","aaaaaaaaep","aaaaaaaaeq","aaaaaaaaer","aaaaaaaaes","aaaaaaaaet","aaaaaaaaeu","aaaaaaaaev","aaaaaaaaew","aaaaaaaaex","aaaaaaaaey","aaaaaaaaez","aaaaaaaafa","aaaaaaaafb","aaaaaaaafc","aaaaaaaafd","aaaaaaaafe","aaaaaaaaff","aaaaaaaafg","aaaaaaaafh","aaaaaaaafi","aaaaaaaafj","aaaaaaaafk","aaaaaaaafl","aaaaaaaafm","aaaaaaaafn","aaaaaaaafo","aaaaaaaafp","aaaaaaaafq","aaaaaaaafr","aaaaaaaafs","aaaaaaaaft","aaaaaaaafu","aaaaaaaafv","aaaaaaaafw","aaaaaaaafx","aaaaaaaafy","aaaaaaaafz","aaaaaaaaga","aaaaaaaagb","aaaaaaaagc","aaaaaaaagd","aaaaaaaage","aaaaaaaagf","aaaaaaaagg","aaaaaaaagh","aaaaaaaagi","aaaaaaaagj","aaaaaaaagk","aaaaaaaagl","aaaaaaaagm","aaaaaaaagn","aaaaaaaago","aaaaaaaagp","aaaaaaaagq","aaaaaaaagr","aaaaaaaags","aaaaaaaagt","aaaaaaaagu","aaaaaaaagv","aaaaaaaagw","aaaaaaaagx","aaaaaaaagy","aaaaaaaagz","aaaaaaaaha","aaaaaaaahb","aaaaaaaahc","aaaaaaaahd","aaaaaaaahe","aaaaaaaahf","aaaaaaaahg","aaaaaaaahh","aaaaaaaahi","aaaaaaaahj","aaaaaaaahk","aaaaaaaahl","aaaaaaaahm","aaaaaaaahn","aaaaaaaaho","aaaaaaaahp","aaaaaaaahq","aaaaaaaahr","aaaaaaaahs","aaaaaaaaht","aaaaaaaahu","aaaaaaaahv","aaaaaaaahw","aaaaaaaahx","aaaaaaaahy","aaaaaaaahz","aaaaaaaaia","aaaaaaaaib","aaaaaaaaic","aaaaaaaaid","aaaaaaaaie","aaaaaaaaif","aaaaaaaaig","aaaaaaaaih","aaaaaaaaii","aaaaaaaaij","aaaaaaaaik","aaaaaaaail","aaaaaaaaim","aaaaaaaain","aaaaaaaaio","aaaaaaaaip","aaaaaaaaiq","aaaaaaaair","aaaaaaaais","aaaaaaaait","aaaaaaaaiu","aaaaaaaaiv","aaaaaaaaiw","aaaaaaaaix","aaaaaaaaiy","aaaaaaaaiz","aaaaaaaaja","aaaaaaaajb","aaaaaaaajc","aaaaaaaajd","aaaaaaaaje","aaaaaaaajf","aaaaaaaajg","aaaaaaaajh","aaaaaaaaji","aaaaaaaajj","aaaaaaaajk","aaaaaaaajl","aaaaaaaajm","aaaaaaaajn","aaaaaaaajo","aaaaaaaajp","aaaaaaaajq","aaaaaaaajr","aaaaaaaajs","aaaaaaaajt","aaaaaaaaju","aaaaaaaajv","aaaaaaaajw","aaaaaaaajx","aaaaaaaajy","aaaaaaaajz","aaaaaaaaka","aaaaaaaakb","aaaaaaaakc","aaaaaaaakd","aaaaaaaake","aaaaaaaakf","aaaaaaaakg","aaaaaaaakh","aaaaaaaaki","aaaaaaaakj","aaaaaaaakk","aaaaaaaakl","aaaaaaaakm","aaaaaaaakn","aaaaaaaako","aaaaaaaakp","aaaaaaaakq","aaaaaaaakr","aaaaaaaaks","aaaaaaaakt","aaaaaaaaku","aaaaaaaakv","aaaaaaaakw","aaaaaaaakx","aaaaaaaaky","aaaaaaaakz","aaaaaaaala","aaaaaaaalb","aaaaaaaalc","aaaaaaaald","aaaaaaaale","aaaaaaaalf","aaaaaaaalg","aaaaaaaalh","aaaaaaaali","aaaaaaaalj","aaaaaaaalk","aaaaaaaall","aaaaaaaalm","aaaaaaaaln","aaaaaaaalo","aaaaaaaalp","aaaaaaaalq","aaaaaaaalr","aaaaaaaals","aaaaaaaalt","aaaaaaaalu","aaaaaaaalv","aaaaaaaalw","aaaaaaaalx","aaaaaaaaly","aaaaaaaalz","aaaaaaaama","aaaaaaaamb","aaaaaaaamc","aaaaaaaamd","aaaaaaaame","aaaaaaaamf","aaaaaaaamg","aaaaaaaamh","aaaaaaaami","aaaaaaaamj","aaaaaaaamk","aaaaaaaaml","aaaaaaaamm","aaaaaaaamn","aaaaaaaamo","aaaaaaaamp","aaaaaaaamq","aaaaaaaamr","aaaaaaaams","aaaaaaaamt","aaaaaaaamu","aaaaaaaamv","aaaaaaaamw","aaaaaaaamx","aaaaaaaamy","aaaaaaaamz","aaaaaaaana","aaaaaaaanb","aaaaaaaanc","aaaaaaaand","aaaaaaaane","aaaaaaaanf","aaaaaaaang","aaaaaaaanh","aaaaaaaani","aaaaaaaanj","aaaaaaaank","aaaaaaaanl","aaaaaaaanm","aaaaaaaann","aaaaaaaano","aaaaaaaanp","aaaaaaaanq","aaaaaaaanr","aaaaaaaans","aaaaaaaant","aaaaaaaanu","aaaaaaaanv","aaaaaaaanw","aaaaaaaanx","aaaaaaaany","aaaaaaaanz","aaaaaaaaoa","aaaaaaaaob","aaaaaaaaoc","aaaaaaaaod","aaaaaaaaoe","aaaaaaaaof","aaaaaaaaog","aaaaaaaaoh","aaaaaaaaoi","aaaaaaaaoj","aaaaaaaaok","aaaaaaaaol","aaaaaaaaom","aaaaaaaaon","aaaaaaaaoo","aaaaaaaaop","aaaaaaaaoq","aaaaaaaaor","aaaaaaaaos","aaaaaaaaot","aaaaaaaaou","aaaaaaaaov","aaaaaaaaow","aaaaaaaaox","aaaaaaaaoy","aaaaaaaaoz","aaaaaaaapa","aaaaaaaapb","aaaaaaaapc","aaaaaaaapd","aaaaaaaape","aaaaaaaapf","aaaaaaaapg","aaaaaaaaph","aaaaaaaapi","aaaaaaaapj","aaaaaaaapk","aaaaaaaapl","aaaaaaaapm","aaaaaaaapn","aaaaaaaapo","aaaaaaaapp","aaaaaaaapq","aaaaaaaapr","aaaaaaaaps","aaaaaaaapt","aaaaaaaapu","aaaaaaaapv","aaaaaaaapw","aaaaaaaapx","aaaaaaaapy","aaaaaaaapz","aaaaaaaaqa","aaaaaaaaqb","aaaaaaaaqc","aaaaaaaaqd","aaaaaaaaqe","aaaaaaaaqf","aaaaaaaaqg","aaaaaaaaqh","aaaaaaaaqi","aaaaaaaaqj","aaaaaaaaqk","aaaaaaaaql","aaaaaaaaqm","aaaaaaaaqn","aaaaaaaaqo","aaaaaaaaqp","aaaaaaaaqq","aaaaaaaaqr","aaaaaaaaqs","aaaaaaaaqt","aaaaaaaaqu","aaaaaaaaqv","aaaaaaaaqw","aaaaaaaaqx","aaaaaaaaqy","aaaaaaaaqz","aaaaaaaara","aaaaaaaarb","aaaaaaaarc","aaaaaaaard","aaaaaaaare","aaaaaaaarf","aaaaaaaarg","aaaaaaaarh","aaaaaaaari","aaaaaaaarj","aaaaaaaark","aaaaaaaarl","aaaaaaaarm","aaaaaaaarn","aaaaaaaaro","aaaaaaaarp","aaaaaaaarq","aaaaaaaarr","aaaaaaaars","aaaaaaaart","aaaaaaaaru","aaaaaaaarv","aaaaaaaarw","aaaaaaaarx","aaaaaaaary","aaaaaaaarz","aaaaaaaasa","aaaaaaaasb","aaaaaaaasc","aaaaaaaasd","aaaaaaaase","aaaaaaaasf","aaaaaaaasg","aaaaaaaash","aaaaaaaasi","aaaaaaaasj","aaaaaaaask","aaaaaaaasl","aaaaaaaasm","aaaaaaaasn","aaaaaaaaso","aaaaaaaasp","aaaaaaaasq","aaaaaaaasr","aaaaaaaass","aaaaaaaast","aaaaaaaasu","aaaaaaaasv","aaaaaaaasw","aaaaaaaasx","aaaaaaaasy","aaaaaaaasz","aaaaaaaata","aaaaaaaatb","aaaaaaaatc","aaaaaaaatd","aaaaaaaate","aaaaaaaatf","aaaaaaaatg","aaaaaaaath","aaaaaaaati","aaaaaaaatj","aaaaaaaatk","aaaaaaaatl","aaaaaaaatm","aaaaaaaatn","aaaaaaaato","aaaaaaaatp","aaaaaaaatq","aaaaaaaatr","aaaaaaaats","aaaaaaaatt","aaaaaaaatu","aaaaaaaatv","aaaaaaaatw","aaaaaaaatx","aaaaaaaaty","aaaaaaaatz","aaaaaaaaua","aaaaaaaaub","aaaaaaaauc","aaaaaaaaud","aaaaaaaaue","aaaaaaaauf","aaaaaaaaug","aaaaaaaauh","aaaaaaaaui","aaaaaaaauj","aaaaaaaauk","aaaaaaaaul","aaaaaaaaum","aaaaaaaaun","aaaaaaaauo","aaaaaaaaup","aaaaaaaauq","aaaaaaaaur","aaaaaaaaus","aaaaaaaaut","aaaaaaaauu","aaaaaaaauv","aaaaaaaauw","aaaaaaaaux","aaaaaaaauy","aaaaaaaauz","aaaaaaaava","aaaaaaaavb","aaaaaaaavc","aaaaaaaavd","aaaaaaaave","aaaaaaaavf","aaaaaaaavg","aaaaaaaavh","aaaaaaaavi","aaaaaaaavj","aaaaaaaavk","aaaaaaaavl","aaaaaaaavm","aaaaaaaavn","aaaaaaaavo","aaaaaaaavp","aaaaaaaavq","aaaaaaaavr","aaaaaaaavs","aaaaaaaavt","aaaaaaaavu","aaaaaaaavv","aaaaaaaavw","aaaaaaaavx","aaaaaaaavy","aaaaaaaavz","aaaaaaaawa","aaaaaaaawb","aaaaaaaawc","aaaaaaaawd","aaaaaaaawe","aaaaaaaawf","aaaaaaaawg","aaaaaaaawh","aaaaaaaawi","aaaaaaaawj","aaaaaaaawk","aaaaaaaawl","aaaaaaaawm","aaaaaaaawn","aaaaaaaawo","aaaaaaaawp","aaaaaaaawq","aaaaaaaawr","aaaaaaaaws","aaaaaaaawt","aaaaaaaawu","aaaaaaaawv","aaaaaaaaww","aaaaaaaawx","aaaaaaaawy","aaaaaaaawz","aaaaaaaaxa","aaaaaaaaxb","aaaaaaaaxc","aaaaaaaaxd","aaaaaaaaxe","aaaaaaaaxf","aaaaaaaaxg","aaaaaaaaxh","aaaaaaaaxi","aaaaaaaaxj","aaaaaaaaxk","aaaaaaaaxl","aaaaaaaaxm","aaaaaaaaxn","aaaaaaaaxo","aaaaaaaaxp","aaaaaaaaxq","aaaaaaaaxr","aaaaaaaaxs","aaaaaaaaxt","aaaaaaaaxu","aaaaaaaaxv","aaaaaaaaxw","aaaaaaaaxx","aaaaaaaaxy","aaaaaaaaxz","aaaaaaaaya","aaaaaaaayb","aaaaaaaayc","aaaaaaaayd","aaaaaaaaye","aaaaaaaayf","aaaaaaaayg","aaaaaaaayh","aaaaaaaayi","aaaaaaaayj","aaaaaaaayk","aaaaaaaayl","aaaaaaaaym","aaaaaaaayn","aaaaaaaayo","aaaaaaaayp","aaaaaaaayq","aaaaaaaayr","aaaaaaaays","aaaaaaaayt","aaaaaaaayu","aaaaaaaayv","aaaaaaaayw","aaaaaaaayx","aaaaaaaayy","aaaaaaaayz","aaaaaaaaza","aaaaaaaazb","aaaaaaaazc","aaaaaaaazd","aaaaaaaaze","aaaaaaaazf","aaaaaaaazg","aaaaaaaazh","aaaaaaaazi","aaaaaaaazj","aaaaaaaazk","aaaaaaaazl","aaaaaaaazm","aaaaaaaazn","aaaaaaaazo","aaaaaaaazp","aaaaaaaazq","aaaaaaaazr","aaaaaaaazs","aaaaaaaazt","aaaaaaaazu","aaaaaaaazv","aaaaaaaazw","aaaaaaaazx","aaaaaaaazy","aaaaaaaazz"};
	
	char[][] cArr = new Char[][]{
	new char[]{'m','b','c','d','e','f','g','h','i','j','k','l'},
	new char[]{'n','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'o','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'p','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'q','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'r','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'s','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'t','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'u','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'v','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'w','a','a','a','a','a','a','a','a','a','a','a'},
	new char[]{'x','y','z','a','a','a','a','a','a','a','a','a'}};
	
	char[][] cArr2 = new char[][] {new char[]{'o','a','a','n'}, new char[]{'e','t','a','e'}, new char[]{'i','h','k','r'}, new char[]{'i','f','l','v'}};
	string[] sArr2 = new string[] {"oath","pea","eat","rain","hklf", "hf", "oa", "oaa"};
	
	//sArr = sArr2;
	//cArr = cArr2;
	
	HashSet<string> hs = new HashSet<string>();
	foreach (var st in sArr)
	{
	   hs.Add(st);
	}
	Console.WriteLine($"Disticnt => {hs.Count} ");
	
	IList<string> lst = Solution.FindWords(cArr, sArr);
	
	Console.WriteLine($"  Input Arr Length = {sArr.Length} ; ResultList Length : {lst.Count}");
	int i = 1;
	foreach(var l in lst)
	{
	   Console.WriteLine($" {i} - {l}");
	   i++;
	}
}

// You can define other methods, fields, classes and namespaces here
public class Solution {
    public static IList<string> FindWords(char[][] board, string[] words) {
        
		Stopwatch sw = new Stopwatch();
		sw.Start();
		
        TrieNode root = new TrieNode('*', false);
        
        for(int i = 0; i < words.Length; i++)
        {
            if((board.Length*board[0].Length) >= words[i].Length)
            {
                root.AddNode(words[i], 0);
            }
        }    
        Console.WriteLine($"Start => Trie Root Words : {root.WordCount}");
                
        IList<string> rst = new List<string>();
        for(int r = 0; r < board.Length; r++)
        {
            for(int c = 0; c < board[r].Length; c++)
            {                      
               Check(board,r,c, root, 'R', new StringBuilder(), new HashSet<int>(), rst, words);			  
            }
        }        
		Console.WriteLine($"End => Trie Root Words : {root.WordCount} => Perf : {sw.Elapsed}");
        return rst;        
    }
    
   private static bool Check(char[][] b, int rI, int cI, TrieNode t, char eD, StringBuilder s, HashSet<int> vCell, IList<string> rst, string[] words)
   {
       bool res = false;
       (bool result, StringBuilder str) = Flood(b, rI,cI, t, 'R', new StringBuilder(), new HashSet<int>());
             
        if(result)
        {
            rst.Add(str.ToString());  
            t.DeleteWord(str.ToString());   
            str.Clear(); str = null;
            res = true;
			// After finding a word and removing it from Trie
			// Cross check if this cell is starting of other word in Trie (input work array)
            if(rst.Count != words.Length)
            {
                for(int i = 0; i < (words.Length - rst.Count); i++)
                {
                   res = Check(b,rI,cI, t, 'R', new StringBuilder(), new HashSet<int>(), rst, words);
				   if(!res) break; // break on first failure, this means no more words match the start of this cell char
                }
            }			
        } 
		return res;
   }
    
    
    private static List<char> sides = new List<char>{'R', 'L', 'B', 'T'};
    
    private static (bool r, StringBuilder s) Flood(char[][] b, int rI, int cI, TrieNode t, char eD, StringBuilder s, HashSet<int> vCell)
    {
        
        if(vCell.Contains((10*rI)+cI) || rI >= b.Length || rI < 0 || cI >= b[0].Length || cI < 0 || t == null || t.Children.Count == 0) return (false, s);
               
        bool rst = false;
        if(t.Children.TryGetValue(b[rI][cI], out TrieNode tN))
        {
            s.Append(b[rI][cI]);
            vCell.Add((10*rI)+cI);
            if(tN.IsWord) return (true, s);
            
           
            foreach(char sd in sides)
            {
                    if(sd== 'R')
                    {
                         cI++;
                         (bool result, StringBuilder str) = Flood(b, rI, cI, tN, sd, s, vCell);
                         rst = result ;
                         if(!result)
                            cI--;
                         else return (rst, s);
                    }
                    if(sd== 'L')
                    {
                         cI--;
                         (bool result, StringBuilder str) = Flood(b, rI, cI, tN, sd, s, vCell);
                        rst = result ;
                         if(!result)
                            cI++;
                         else return (rst, s);
                    }
                    if(sd== 'B')
                    {
                         rI++;
                         (bool result, StringBuilder str) = Flood(b, rI, cI, tN, sd, s, vCell);
                        rst = result ;
                         if(!result)
                            rI--;
                         else return (rst, s);
                    }
                    if(sd== 'T')
                    {
                         rI--;
                         (bool result, StringBuilder str) = Flood(b, rI, cI, tN, sd, s, vCell);
                        rst = result ;
                         if(!result)
                            rI++;
                         else return (rst, s);
                    }                
            }
            
            if(!rst)
            {
                vCell.Remove((10*rI)+cI);
                s.Remove(s.Length-1, 1);
            }            
        }   
        return (rst, s);
    }
    
    public class TrieNode
    {
        public char C { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; }
        public bool IsWord { get; set; }
		public int WordCount {get; private set; }
        
        public TrieNode(char c, bool isWord = false)
        {
            C = c;
            Children = new Dictionary<char, TrieNode>();
            IsWord = isWord;
        }
        
        public bool Search(string s, int idx = 0)
        {
            if(string.IsNullOrWhiteSpace(s) || idx >= s.Length) return false;
            
            bool isLast = (idx+1) == s.Length;
            
            if(Children.TryGetValue(s[idx], out TrieNode t))
            {
                if(isLast) return t.IsWord;
                else return true;
            }
            
            return false;
        }
        
        public void AddNode(string s, int idx = 0)
        {
            if(string.IsNullOrWhiteSpace(s) || idx >= s.Length) return;
			
			if(idx == 0) WordCount++;
            
            bool isLast = (idx+1 == s.Length);
            TrieNode t = null;
            if(Children.TryGetValue(s[idx], out t))
            {
                if(isLast) t.IsWord = true;
            }
            else
            {
                t = new TrieNode(s[idx], isLast);
                Children.Add(s[idx], t);                
            }
            t.AddNode(s, ++idx);
			
        }
        
        public bool DeleteWord(string s, int idx = 0)
		{		   
		   if(string.IsNullOrWhiteSpace(s) || idx > s.Length) return false;
		   if(idx == s.Length) return true;
		   
           if(Children.TryGetValue(s[idx], out TrieNode t) && t.DeleteWord(s, ++idx))
		   {
		       if(t.Children.Count == 0) Children.Remove(t.C);
			   else t.IsWord = false;
               
			   if(C == '*') WordCount--;
			   return true;
		   }		   
		   return false;
		}
        
        public override string ToString()
        {
            Console.Write($"{C} - {IsWord} ; ");
            foreach(var d in Children)
            {
                d.Value.ToString();
            }
            return $"{C}";
        }
    }
}