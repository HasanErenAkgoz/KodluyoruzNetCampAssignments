Select country from country
where country like 'A%a';

-- Cevap 2-)
Select country from country
where country like '_____%n';

-- Cevap 3-)
select title from film
where title ilike '%T%T%T%T%';

-- Cevap 4-)
select * from film 
where title like 'C%' and length>90 and rental_rate=2.99;