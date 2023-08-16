SELECT Goods.Name,Categories.Name FROM Goods
LEFT JOIN Goods_Categories on Goods.ID = Goods_Categories.Goods_id 
LEFT JOIN Categories on Goods_Categories.Category_id = Categories.ID