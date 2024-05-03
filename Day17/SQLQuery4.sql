use pubs;



 -- 1) Print the storeid and number of orders for the store
 select stor_id , count(ord_num) as number_of_order from sales group by stor_id ;

 -- 2) print the numebr of orders for every title
 select title_id , count(ord_num) as number_of_order from sales group by title_id ;

 -- 3) print the publisher name and book name
 select p.pub_name, t.title from publishers p join titles t on p.pub_id = t.pub_id; 

 -- 4) Print the author full name for al the authors
 select CONCAT(au_fname,' ' ,au_lname) as Fullname from authors;

 -- 5) Print the price or every book with tax (price+price*12.36/100)
 select title,  (price*112.36/100) as tax from titles;

 -- 6) Print the author name, title name
 select a.au_fname , t.title from titles t join titleauthor on t.title_id = titleauthor.title_id join authors a 
 on titleauthor.au_id = a.au_id ;

 -- 7) print the author name, title name and the publisher name
 SELECT 
    a.au_fname AS [Author First Name],
    a.au_lname AS [Author Last Name],
    t.title AS [Title],
    p.pub_name AS [Publisher Name] FROM authors a JOIN titleauthor ta ON a.au_id = ta.au_id
JOIN 
    titles t ON ta.title_id = t.title_id
LEFT JOIN 
    publishers p ON t.pub_id = p.pub_id;
 -- 8) Print the average price of books pulished by every publicher

 select avg(price) as Average_price ,pub_id from titles group by pub_id;

 -- 9) print the books published by 'Marjorie'
 select t.* from titles t join publishers p on t.pub_id = p.pub_id where p.pub_name= 'Marjorie';

 -- 10) Print the order numbers of books published by 'New Moon Books'
 select ord_num from sales where title_id in (select title_id from titles where pub_id in (select 
 pub_id from publishers where pub_name ='New Moon Books')) ;

 -- 11) Print the number of orders for every publisher
 select count(ord_num) as Number_of_orders, p.pub_id from sales s join titles t on s.title_id  = t.title_id 
 join publishers p on p.pub_id  = t.pub_id group by p.pub_id ;

 -- 12) print the order number , book name, quantity, price and the total price for all orders
 select s.ord_num , t.title, s.qty  from sales s join titles t on s.title_id = t.title_id; 
 -- 13) print he total order quantity fro every book
  select sum(s.qty) as Order_Quantity, t.title_id as "Title"  from sales s join titles t on s.title_id = t.title_id group by t.title_id; 
 -- 14) print the total ordervalue for every book
 select s.n * t.price as order_value, t.title from titles t join   ( select count(ord_num) as n, title_id from sales group by title_id) as s on s.title_id = t.title_id ; ;
 -- 15) print the orders that are for the books published by the publisher for which 'Paolo' works for
