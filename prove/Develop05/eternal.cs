public class Eternal:Goals
{
      public Eternal(string name, string type, int point):base(name,type,point)
      {

      }
      public override void Display(int i)
      {
        
            Console.WriteLine("The goals are:");
            Console.WriteLine($"{i} [ ] {_name} ({_type}) ");
        
      }

       public override string Saveformat()
   {
      return $"EternalGoals:{_name},{_type},{_point}";
   }
   public override int CompletedGoals()
   {
         return _point;
         
      }
      
}


