---
layout: post
title:  "Oracle Enterprise Data Quality (OEDQ) / EDQ Advanced matchers"
date:   2015-07-30 12:00:00
quote:  "You can tell a lot about a person from his Biography. — Phil Dunphy [Phil’s-osophy]"
categories: OEDQ, Oracle Enterprise Data Quality, SQL, SQL Server, Data Validation
---
## What is OEDQ?

[Oracle Enterprise Data Quality (OEDQ) or (EDQ)](http://www.oracle.com/technetwork/middleware/oedq/overview/index.html) baiscally enables an organisation to govern data, it facilitates data integration and has the capability to extract basic business intelligence. The objective in this application of OEDQ was data cleansing. The first step was to identify and report to business the specific records and fields that need to be addressed to improve data integrity. It also allowed us to identify where serious input validation is required or where client side validation failed and server side validation was omitted.

## Set up OEDQ

* On installing OEDQ I selected all the functional packs.

	![alt text]({{ site.url }}/assets/1_select_all_options.png)

* When opening up the OEDQ Launchpad at: [https://localhost:9004/dndirector/](https://localhost:9004/dndirector/) and clicking on [_Launch..._](https://localhost:9004/dndirector/blueprints/director/jnlp) underneath Director a _jnlp.jnlp_ file should be downloaded.

	![alt text]({{ site.url }}/assets/2_launch_dashboard.png)

* If when opening the _jnlp_ you are prompted with the below dialog (screen shot 1), got to _Windows > Control Panel > Java_ or _Configure Java_. You need to **Enable Java content in the browser** and click on the **Edit Site List...** button to add   _https://localhost:9004_ (screen shot 2 & 3).

	Screen shot 1:

	![alt text]({{ site.url }}/assets/3_not_enabled_java_windows.PNG "Java not enabled")

	Screen shot 2:

	![alt text]({{ site.url }}/assets/4_enabled_java_windows.PNG "Enable Java content in the browser")
	
	Screen shot 3:

	![alt text]({{ site.url }}/assets/5_add_site_exception.PNG "Edit Site List...")

## OEDQ basics

The main work flow is pretty simple once you get the hang of it.

Menu:

![alt text]({{ site.url }}/assets/2_workflow_menu.PNG "Menu")

Work flow:

![alt text]({{ site.url }}/assets/2_workflow.PNG "Work flow")

# A Basic work flow to match City in two tables

Right clicking on the menu items provides you with the option to create a new instance of an item. In the steps below just follow the creation wizard.

1. Set up a Source Data Store - this will be the database connection.

	Once you created a project you start with a data store (right click on _Data Stores > New Data Store..._).<sup><sup>...if you want to use it across projects you can create one in the top level Data Stores otherwise under a project is fine.</sup></sup>

	![alt text]({{ site.url }}/assets/2.1_datastore.PNG "New Data Store...")

2. Create Snapshots of the data you need to evaluate.
	
	In my case I created two snapshots one of the _Customers_ table and another of the _Employees_ table.<sup><sup>(You can create an SQL query as well if you would like a more targeted approach.)</sup></sup>
		
	![alt text]({{ site.url }}/assets/2.2_snapshots.PNG "SnapShots")
	
	You can see the city column in both the _Customers_ and _Employees_ tables.

3. Create a process to profile the tables, start with a Reader for the _Customers_ table.
	
	3.1 Choose the _Customers_ table and run through the wizard.
	
	![alt text]({{ site.url }}/assets/3.1_source.PNG "Source")
	
	3.2 You do not have to _Add Profiling_.
	
	![alt text]({{ site.url }}/assets/3.2_profile.PNG "Profiling")
	
	3.3 This provides us with a process that does not do anything.
	
	![alt text]({{ site.url }}/assets/3.3_process1.PNG "Process")
	
4. Add another Reader for the _Employees_ table.

	4.1 Select the Data Store icon on the _Tool Palette_ and drag a **Reader** on.
	
	![alt text]({{ site.url }}/assets/4.1_reader1.PNG "Reader Employees")
	
	4.2 
	
	
## Additional Information
* Although the documentation has some crucial information hidden (in a note sections or greyed out sections) it really is helpful and does explain the reasoning behind the functionality and the operations one can perform.

	[![alt text]({{ site.url }}/assets/oedq_note_ind.png "Crucial Information")][OEDQHelp]

## Moral:

So what can we take from Phil's infinite wisdom?

  * "You can tell a lot about a person from his Biography." — Phil Dunphy [Phil’s-osophy]
 
    **_Read the help documentation, it helps..._**
 
 
[OEDQHelp]:http://www.oracle.com/webfolder/technetwork/data-quality/edqhelp/Content/concepts/jobs.htm