CREATE TABLE #products (
       id numeric not NULL,
       name nvarchar(20) null,
       constraint products_pkey primary key (id)
);

insert into #products(id, name)
values (1, 'Хлеб'),(2, 'Колбаса'),(3, 'Молоко'),(4, 'Масло'),(5, 'Стол'),(6, 'Стул'),(7, 'Ноутбук');

CREATE TABLE #maping (
       id numeric not null,
       product_id numeric null,
       category_id numeric null,
       constraint mapping_pkey primary key (id)
);

insert into #maping (id, product_id, category_id)
values (1, 1, 1), (2, 2, 1), (3, 3, 1), (4, 4, 1), (5, 3, 2), (6, 4, 2), (7, 5, 3), (8, 6, 3);

CREATE TABLE #category (
       id numeric not NULL,
       name nvarchar(20) null,
       constraint category_pkey primary key (id)
);

insert into #category(id, name)
values (1, 'Продукты'),(2, 'Молочные изделия'),(3, 'Мебель'),(4, 'Хоз товары');

select p.name products_name, c.name category_name
from #products p
left join #maping m on p.id = m.product_id
left join #category c on m.category_id = c.id

--drop table #products;
--drop table #category;