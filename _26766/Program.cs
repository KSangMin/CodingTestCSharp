using System.Text;

int n = int.Parse(Console.ReadLine()!);
StringBuilder sb = new();
for (int i = 0; i < n; i++)
{
    sb.AppendLine(@" @@@   @@@ 
@   @ @   @
@    @    @
@         @
 @       @ 
  @     @  
   @   @   
    @ @    
     @     ");
}

Console.Write(sb.ToString());