## Database Systems - Overview
### _Homework_

####1. What database models do you know?

* *__Hierarchical (tree)__* where the data is organized into a tree-like structure, implying a single parent for each record.
* *__Network model__*  which expands upon the __hierarchical structure__, allowing many-to-many relationships in a tree-like structure that allows multiple parents.
* *__Relational model:__* The basic data structure of the relational model is the table, where information about a particular entity (say, an employee) is represented in rows (also called tuples) and columns. Thus, the "relation" in "relational database" refers to the various tables in the database; a relation is a set of tuples.
* *__Object-oriented:__* In the 1990s, the object-oriented programming paradigm was applied to database technology, creating a new database model known as object databases. This aims to avoid the object-relational impedance mismatch - the overhead of converting information between its representation in the database (for example as rows in tables) and its representation in the application program (typically as objects). Even further, the type system used in a particular application can be defined directly in the database, allowing the database to enforce the same data integrity invariants. Object databases also introduce the key ideas of object programming, such as encapsulation and polymorphism, into the world of databases.

####2. Which are the main functions performed by a Relational Database Management System (RDBMS)?

* It stores data in tables.
* Sharing a common column in two or more tables (primary and foreign key)
* Tables have rows and column. 
* These tables are created using SQL. 
* And data from these tables are also retrieved using SQL.
* Provides facility primary key to uniquely identify the rows.

####3. Define what is "table" in database terms.

* Database table A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.

####4. Explain the difference between a primary and a foreign key.

* The __primary key__ consists of one or more columns whose data contained within is used to uniquely identify each row in the table.  You can think of the primary key as an address.  If the rows in a table were mailboxes, then the primary key would be the listing of street addresses.
* A __foreign key__ is a set of one or more columns in a table that refers to the primary key in another table.  There isn’t any special code, configurations, or table definitions you need to place to officially “designate” a foreign key.

####5. Explain the different kinds of relationships between tables in relational databases.

A relationship works by matching data in key columns — usually columns with the same name in both tables. In most cases, the relationship matches the primary key from one table, which provides a unique identifier for each row, with an entry in the foreign key in the other table. For example, book sales can be associated with the specific titles sold by creating a relationship between the title_id column in the titles table (the primary key) and the title_id column in the sales table (the foreign key).
* *__One-to-Many Relationship:__* A one-to-many relationship is the most common type of relationship. In this type of relationship, a row in table A can have many matching rows in table B, but a row in table B can have only one matching row in table A. For example, the publishers and titles tables have a one-to-many relationship: each publisher produces many titles, but each title comes from only one publisher.
* *__Many-to-Many Relationships:__* In a many-to-many relationship, a row in table A can have many matching rows in table B, and vice versa. You create such a relationship by defining a third table, called a junction table, whose primary key consists of the foreign keys from both table A and table B. For example, the authors table and the titles table have a many-to-many relationship that is defined by a one-to-many relationship from each of these tables to the titleauthors table. The primary key of the titleauthors table is the combination of the au_id column (the authors table's primary key) and the title_id column (the titles table's primary key).
* *__One-to-One Relationships:__* In a one-to-one relationship, a row in table A can have no more than one matching row in table B, and vice versa. A one-to-one relationship is created if both of the related columns are primary keys or have unique constraints.
This type of relationship is not common because most information related in this way would be all in one table. You might use a one-to-one relationship to:
  * Divide a table with many columns.
  * Isolate part of a table for security reasons.
  * Store data that is short-lived and could be easily deleted by simply deleting the table.
  * Store information that applies only to a subset of the main table.

####6. When is a certain database schema normalized?
Database normalization (or normalisation) is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy.

Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.

__Advantages:__
* Smaller database: By eliminating duplicate data, you will be able to reduce the overall size of the database.
* Better performance:
  * Narrow tables: Having more fine-tuned tables allows your tables to have less columns and allows you to fit more records per data page.
  * Fewer indexes per table mean faster maintenance tasks such as index rebuilds.
  * Only join tables that you need.

####7. What are database integrity constraints and when are they used?

Integrity constraints provide a mechanism for ensuring that data conforms to guidelines specified by the database administrator. The most common types of constraints include:

* UNIQUE constraints to ensure that a given column is unique

* NOT NULL constraints to ensure that no null values are allowed

* FOREIGN KEY constraints to ensure that two keys share a primary key to foreign key relationship

Constraints verify that the data conforms to a basic level of data consistency and correctness, preventing the introduction of dirty data.

####8. Point out the pros and cons of using indexes in a database.

The indexing increases the disk space usage and reduces the performance of adding, deleting, and updating, but in most cases the benefit of indices for data retrieval greatly exceeds the disadvantages.
* *__Pros:__*
  * Fast searching
  * Fast sorting
* *__Cons:__*
  * Slow insert
  * Slow update

####9. What's the main purpose of the SQL language?

SQL (Structured Query Language) is a special-purpose programming language designed for managing data held in a relational database management system (RDBMS), or for stream processing in a relational data stream management system (RDSMS).

The main purpose of SQL is to provide a Structured way by which one can Query information in database using a standard Language.

####10. What are transactions used for?

A transaction symbolizes a unit of work performed within a database management system (or similar system) against a database, and treated in a coherent and reliable way independent of other transactions. A transaction generally represents any change in database.

Transactions provide an "all-or-nothing" proposition, stating that each work-unit performed in a database must either complete in its entirety or have no effect whatsoever. Further, the system must isolate each transaction from other transactions, results must conform to existing constraints in the database, and transactions that complete successfully must get written to durable storage.

There are four important properties of database transactions these are represented by acronym ACID and also called ACID properties or database transaction where:

A stands for Atomicity, Atom is considered to be smallest particle which can not be broken into further pieces.database transaction has to be atomic means either all steps of transaction completes or none of them.

C stands for Consistency, transaction must leave database in consistent state even if it succeed or rollback.

I is for Isolation
Two database transactions happening at same time should not affect each other and has consistent view of database. This is achieved by using isolation levels in database.

D stands for Durability
Data has to be persisted successfully in database once transaction completed successfully and it has to be saved from power outage or other threats. This is achieved by saving data related to transaction in more than one places along with database.

*__Example:__*

For this example we will assume we have an Account table which represent a Bank Account and we will transfer money from one account to another account

Request: transfer 900$ from Account 9001 to 9002
```
start transaction
select balance from Account where Account_Number='9001';
select balance from Account where Account_Number='9002';
update Account set balance=balance-900 here Account_Number='9001' ;
update Account set balance=balance+900 here Account_Number='9002' ;
commit; //if all sql queries succed
rollback; //if any of Sql queries failed or error
  
####11. What is a NoSQL database?

A NoSQL (originally referring to "non SQL" or "non relational") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases.

Motivations for this approach include: simplicity of design, simpler "horizontal" scaling to clusters of machines, which is a problem for relational databases, and finer control over availability. The data structures used by NoSQL databases (e.g. key-value, graph, or document) differ slightly from those used by default in relational databases, making some operations faster in NoSQL and others faster in relational databases. The particular suitability of a given NoSQL database depends on the problem it must solve. Sometimes the data structures used by noSQL databases are also viewed as "more flexible" than relational database tables.

NoSQL databases are increasingly used in big data and real-time web applications. NoSQL systems are also sometimes called "Not only SQL" to emphasize that they may support SQL-like query languages.

####12. Explain the classical non-relational data models.

*  *__Key-Value stores:__* Typically, these DMS store items as alpha-numeric identifiers (keys) and associated values in simple, standalone tables (referred to as ―hash tables‖). The values may be simple text strings or more complex lists and sets. Data searches can usually only be performed against keys, not values, and are limited to exact matches.
*  *__Document databases__* document databases were, as their name implies, designed to manage and store documents. These documents are encoded in a standard data exchange format such as XML, JSON (Javascript Option Notation) or BSON (Binary JSON). Unlike the simple key-value stores described above, the value column in document databases contains semi-structured data – specifically attribute name/value pairs. A single column can house hundreds of such attributes, and the number and type of attributes recorded can vary from row to row. Also, unlike simple key-value stores, both keys and values are fully searchable in document databases.
*  *__Wide-Column (or Column-Family) Stores (BigTable-implementations):__* Like document databases, Wide-Column (or Column-Family) stores (hereafter WC/CF) employ a distributed, column-oriented data structure that accommodates multiple attributes per key.
*  *__Graph databases:__* Graph databases replace relational tables with structured relational graphs of interconnected key-value pairings. They are similar to object-oriented databases as the graphs are represented as an object-oriented network of nodes (conceptual objects), node relationships (―edges‖) and properties (object attributes expressed as key-value pairs). They are the only of the four NoSQL types discussed here that concern themselves with relations, and their focus on visual representation of information makes them more human-friendly than other NoSQL DMS.

####13. Give few examples of NoSQL databases and their pros and cons.

* *__Casssandra:__* The Apache Cassandra project emerged out of Facebook in 2008 and is now a fully grown tool used for many large data stores and integrated with other popular tools like Solr. The mechanism offers a hybrid mixture of a column-oriented database with a key/value store. Not every row must have each column, but the columns are grouped into families that make them feel like tables. The system offers a tunable amount of replication and consistency. In one recent test, Netflix built a cluster of 288 nodes and found writes scaled linearly.
* *__CouchDB:__* CouchDB data arrives in JavaScript's JSON format, its queries are written in JavaScript, and the data goes back in JSON. It's a database built for the Web and the people who program it. (Sidenote: Some use CouchDB offline in the background of mobile apps.) CouchDB stores key/value pairs and propagates them over the nodes, offering eventual consistency. There's also a more commercial cousin, Couchbase, that offers caching, better sharding, incremental queries, better indices, and a few more features.
* *__Oracle NoSQL:__* The wizards at Oracle took one look at the NoSQL movement and decided they needed to have a product that would split up key/value pairs across a collection of nodes. The resulting Oracle NoSQL offers a flexible amount of transaction protection that can range from acknowledging the data is stored on one node to waiting until it is successfully backed up across the network.
* *__MongoDB:__* MongoDB has all of the classic features that define NoSQL: key/value storage, JavaScript formatting, and flexible replication for sharding across nodes. (Sharding is illustrated.) The data is written with a philosophy MongoDB calls multiversion concurrency control, a structure that keeps older versions of the data around to help keep consistency in complicated transactions. The user base is large, and there is a wide selection of ancillary tools, no doubt thanks to the open source option (strict AGPL).
* *__Hadoop (HBase):__* While most people think of Hadoop and all of its tools as a mechanism for harnessing the power of many machines, Hadoop also includes a database, HBase, that spreads data out among the nodes. The map/reduce structure of Hadoop is well-suited for complicated computational jobs or queries that are farmed out to each node. The field is growing, and new databases for each node like Accumulo are enhancing the Hadoop platform.
* *__DynamoDB:__* Amazon Web Services offers more ways to store data than there are fingers on one hand. DynamoDB is the NoSQL solution that takes key/value pairs and spreads them out across servers in three different zones where all the data is stored on SSDs. If you anticipate more demand for the traffic, DynamoDB will add more servers behind the scenes.

*__Pros and Cons:__*

* *__Pros:__*
  * It's Open Source - Open source products provide developers with some great benefits, notably their no-cost status. Other benefits: open-source software tends to be more reliable, secure, and faster to deploy than proprietary alternatives.
  * Elastic Scaling - NoSQL replaces the old 'scale up' mantra of database managers with a new one: 'scale out.' Instead of adding bigger servers to handle more data load, a NoSQL database allows a company to distribute the load across multiple hosts as the load increases.
  * Different NoSQL DBs for Different Projects - MongoDB and Redis are good choices for storing frequently-written, rarely read statistical data, such as a web hit counter. Hadoop, a freeform, distributed DB does a good job of storing Big Data such as weather stats or business analytics work. Memcache, a transient DB, excels at storing web sessions, locks, and short-term stats). Cassandra and Riak (automatically clustered, redundant stores) perform well in environments with high availability apps, when maximum uptime is vital.
  * NoSQL’s Impressive Implementations - Companies such as Amazon, the BBC, Facebook and Google rely on NoSQL DBs.
  * NoSQL Flies High in the Cloud - NoSQL and the cloud are a natural fit. Today’s servers are inexpensive and can easily be scaled up on demand using a service such as Amazon EC2. Like all cloud technology, EC2 is based on virtualization. The weak link of virtualization is I/O performance, with memory and CPU being the strong links. NoSQL databases mostly use memory over disk as the primary write location – thereby preventing inconsistent I/O performance. And since NoSQL datastores typically leverage horizontal scalability via partitioning, they are able to take advantage of the cloud’s elastic provisioning.
* *__Cons:__* 
  * Open Source can Mean Spotty Support for Enterprises
  * Not Mature Enough for Enterprises
  * Business Intelligence Limitations
  * Lack of Expertise
  * Compatibility Issues