using _30noemberi;

ZooManager zoom = new ZooManager();
Mammal m = new Mammal();
m.Name = "Elephant";
m.Age = 25;
m.Weight = 5000;
m.Habitat = "Jungle";
zoom.AddMammal(m);
Bird b = new Bird();
b.Name = "Eagle";
b.Age = 5;
b.Weight = 3.5;
b.CanFly = true;
zoom.AddBird(b);
zoom.ListBird();
zoom.ListMammal();
zoom.FindHeaviestMammal().DescribeMammal();