use Foodmart;

select *from Sales_Fact_1998;
select *from customer;
select *from region;

SELECT store_id, sum(store_sales) as total_sales FROM sales_fact_1998 group by store_id order by sum(store_sales) desc;

SELECT store_id, sum(store_sales) as total_sales FROM sales_fact_1998 group by store_id order by store_id asc;

SELECT time_by_day.the_month , sum(store_sales) AS total_sales FROM sales_fact_1998 
INNER JOIN time_by_day ON  sales_fact_1998.time_id=time_by_day.time_id 
GROUP BY time_by_day.the_month ORDER BY the_month asc;

-- Good one--
SELECT time_by_day.the_month , sum(store_sales) AS total_sales FROM sales_fact_1998 
INNER JOIN time_by_day ON  sales_fact_1998.time_id=time_by_day.time_id 
GROUP BY time_by_day.the_month ORDER BY DATEPART(mm,CAST(the_month+ ' 1900' AS DATETIME)) asc;


select *from product_class;
SELECT product_class_id, product_subcategory from product_class;
select *from product;

SELECT product_name from product ORDER BY product_name ASC;

select *from region;


SELECT sales_city from region ORDER BY sales_city ASC;


SELECT product.product_Name from product 
INNER JOIN product_class ON
 product_class.product_class_id=product.product_class_id WHERE product_subcategory='Nuts'ORDER BY product_Name ASC;