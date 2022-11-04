using Factory;

var shapeFactory = new ShapeFactory();

var circle =shapeFactory.CreateShape(ShapeType.Circle);
circle.Render();
