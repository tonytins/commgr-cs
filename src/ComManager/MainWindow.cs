using Terminal.Gui;

namespace ComManager;

public class MainWindow : Window
{
  public MainWindow()
  {
	Title = "Commission Manager";

	var items = new List<string>() { "Standard", "Your Character Here", "Adoptable" };

	var nameLabel = new Label()
	{
	  Text = "Name",
	};

	var nameText = new TextField()
	{
	  X = Pos.Right(nameLabel) + 1,
	  Width = Dim.Fill(2)
	};

	var typeLabel = new Label()
	{
	  Text = "Type",
	  X = Pos.Left(nameLabel),
	  Y = Pos.Bottom(nameLabel)
	};

	var typeInput = new ComboBox()
	{
	  X = Pos.Left(typeLabel) + 1,
	  Y = Pos.Bottom(nameText),
	  Width = Dim.Fill(2),
	};
	typeInput.SetSource(items);

	Add(nameLabel, nameText, typeLabel, typeInput);
  }
}