class Date {
    static void Main (String[] args) {
for (long timestamp = 1000; timestamp <=1000000; timestamp *= 10) {
DateTime t = System.DateTimeOffset.FromUnixTimeMilliseconds(timestamp).DateTime;
    Console.WriteLine(t.ToString());
        }
    }
}

git init
git add Program.cs
git commit -m "first commit"
git branch -M main
git remote add origin git@github.com:Poe1312/Kittens.git
git push -u origin main