string myString = "AbCdEfG";
string pat = "aBc";

int answer = myString.ToLower().Contains(pat.ToLower()) ? 1 : 0;

return answer;