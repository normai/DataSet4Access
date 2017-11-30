
# DataSet4Access *v0.1*

## Introduction

This project demonstrates how to make a **DataSet** on a WinForm
work against an **Access 2007** database file with hierarchical
table relations. The data is displayed and edited in **DataGridView**s.
The program is written in Visual Basic with Visual Studio Community 2017 edition.

The mission sounds trivial, but is devilish in fact.

This are the hurdles to overcome :

1. The DataSet natively **does not support** hierarchical
table relations. To make it work, you need to supplement the
wizzard's code manually.

2. After having managed step one, you will find, that the
supplemented code works with all databases, **except MS Access**.
More code is to be supplemented, actually non-trivial code.

3. On the way lie around smaller **stumbling blocks**, which
are nice to know in advance.

## About the Project

(1) We have an Access 2007 database with hierarchical table relations.
It are two tables, one master, one child.
The database design looks like this :

![We have an Access database with two tables, one master, one child.](./pages/img/20170811o0642.access--view-relationships--cut.png?raw=true)

(2) We want a WinForm with two DataGridViews to edit this tables.
The form shall look like this :

![From two WinForms DataGridViews, we want edit this tables.](./pages/img/20171126o0141.winforms-hierarchical-datagridviews.png?raw=true)

(3) But when attempting to insert a record in one of the tables,
the application crashes. In the debugger, it looks like this :

![When inserting a record, this exception fires.](./pages/img/20170811o174121.vs--clubman--run--exception.png?raw=true)

**Big challenge!** How can we insert any record?
The reason for the crashing is hard to find,
not to mention the solution.

For the solution please see this page: [HTML file](./pages/index.html).

*Oops, sorrily, GitHub will not show this page as I have carelessly intended.
To view the page meaningful in your browser, you need to download the
project, and view the page locally. I plan to fix this occasionally.*

## The Teachers

To win the challenge, I had to read many pages on the web.
Finally, two non-trivial articles in combination delivered the solution.

This project is the realisation and combination of those two articles :

1. MSDN article [Walkthrough: Saving Data from Related Data Tables (Hierarchical Update)](https://msdn.microsoft.com/en-us/library/bb384432.aspx)

2. Beth Massi's blog [Using TableAdapters to Insert Related Data into an MS Access Database](https://blogs.msdn.microsoft.com/bethmassi/2009/05/14/using-tableadapters-to-insert-related-data-into-an-ms-access-database/)

## Note

This project is a **dirty quick** shot, not ready yet, but possibly already helpful anyway.

License: [The MIT License](https://mit-license.org/).

*Norbert*

*2017-Nov-29*
