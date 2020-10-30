select i.IngredientName, m.MeasurementDescription
from Recipe_Ingredients ri
right join Ingredients i
on i.IngredientID = ri.IngredientID
right join Measurements m
on m.MeasureAmountID = i.MeasureAmountID
where i.IngredientID is Null