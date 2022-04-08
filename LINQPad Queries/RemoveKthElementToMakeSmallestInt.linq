<Query Kind="Program" />

void Main()
{
	Solution s = new Solution();		
	Console.WriteLine($"{s.RemoveKdigits("99641436378815", 4)}");
	Console.WriteLine($"{s.RemoveKdigits("1432219", 3)}");
	Console.WriteLine($"{s.RemoveKdigits("10200", 1)}");
}


public class Solution {
    public string RemoveKdigits(string num, int k) {
        if(string.IsNullOrWhiteSpace(num)) return "0";
        string result = string.Empty;
     
        Dueque s = new Dueque(num.Length);
        s.Push(num[0]);
        int i = 1;
        do
        {
            for(; i < num.Length; i++)
            {
                if(!s.IsEmpty && k != 0 && s.PeekPop() >= num[i])
                {
                    s.Pop(); k--;      
                }               
                s.Push(num[i]);  
            }
            if(k != 0 && !s.IsEmpty)
            {
                char c = s.Pop();
                if(!s.IsEmpty && s.PeekPop() > c )
                {
                    s.Pop(); s.Push(c);
                }
                k--;  
            }
        }while(k != 0);
        
        while(s.Count > 0)
        {
           if(result == string.Empty && !s.IsEmpty && s.PeekDequeue() == '0')
           {
               s.Dequeue();                
           }
            else
           {
               result += s.Dequeue();
           }
        }
        if(result == string.Empty) result = "0";
        
        return result;
    }
    
    public class Dueque
    {
        char[] arr;
        int c = 0, nxtInsIdx = -1, enqIdx = -1;        
        public Dueque(int cap)
        {
            c= cap;
            arr = new char[c];
            nxtInsIdx = 0;
        }
        
        public char PeekPop()
        {
            if(IsEmpty) throw new Exception("Deque is empty");
            return arr[nxtInsIdx-1];    
        }
        
        public char PeekDequeue()
        {
             if(IsEmpty)  throw new Exception("Deque is empty");            
            return arr[enqIdx];   
        }
        
        public void Push(char c)
        {
            if(IsFull) return;
            arr[nxtInsIdx] = c;
            if(nxtInsIdx == 0) enqIdx = 0;
            nxtInsIdx++;            
        }
        
        public char Pop()
        {
            if(IsEmpty) throw new Exception("Deque is empty");
            char c =  arr[--nxtInsIdx];
            if(nxtInsIdx < 0) {nxtInsIdx++; enqIdx = -1;}
            return c;              
        }
        
        public char Dequeue()
        {
            if(IsEmpty)  throw new Exception("Deque is empty");
            //Console.WriteLine($"{enqIdx}");
            return arr[enqIdx++];               
        }
        
        public bool IsFull
        {
            get { return nxtInsIdx == c; }
        }
        
        public bool IsEmpty
        {
            get { return nxtInsIdx == 0; }
        }
        
        public int Count
        {
            get { return (nxtInsIdx)-enqIdx;}
        }
    }
}