---
layout: post
title:  "Oracle Enterprise Data Quality (OEDQ) / EDQ Advanced matchers"
date:   2015-07-31 21:52:00
quote:  "You can tell a lot about a person from his Biography. — Phil Dunphy [Phil’s-osophy]"
categories: OEDQ, Oracle Enterprise Data Quality, SQL, SQL Server, Data Validation
---
## What is OEDQ?

[Oracle Enterprise Data Quality (OEDQ) or EDQ](http://www.oracle.com/technetwork/middleware/oedq/overview/index.html) baiscally enables an organisation to govern data, it facilitates data integration and has the capability to extract basic business intelligence. The objective in applying OEDQ was data cleansing. The first step was to identify and report to business the specific records and table fields that need to be addressed to improve data quality and in cases of weak references, data integrity. It also allowed us to identify where serious input validation is required or where client side validations fails and server side validation is omitted.

## Set up OEDQ
	
* On installing **OEDQ version 9.0.8 (1103)**, I selected all the functional packs.

	![alt text]({{ site.url }}/assets/1_select_all_options.png)

* When opening up the OEDQ Launchpad at: [https://localhost:9004/dndirector/](https://localhost:9004/dndirector/) and clicking on [_Launch..._](https://localhost:9004/dndirector/blueprints/director/jnlp) underneath Director a _jnlp.jnlp_ file should be downloaded.

	![alt text]({{ site.url }}/assets/2_launch_dashboard.PNG)

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

Right clicking on the menu items provides you with the option to create a new instance of an item.

1. Set up a Source Data Store - this will be the database connection.

	Once you created a project you start with a data store (right click on _Data Stores > New Data Store..._).<sup><sup>...if you want to use it across projects you can create one in the top level Data Stores otherwise under a project is fine.</sup></sup>

	![alt text]({{ site.url }}/assets/2.1_datastore.PNG "New Data Store...")

2. Create Snapshots of the data you need to evaluate.
	
	In my case I created two snapshots one of the _Customers_ table and another of the _Employees_ table.<sup><sup>(You can create an SQL query as well if you would like a more targeted approach.)</sup></sup>
		
	![alt text]({{ site.url }}/assets/2.2_snapshots.PNG "SnapShots")
	
	You can see the city column in both the _Customers_ and _Employees_ tables.

3. Create a process to profile the tables, start with a Reader for the _Customers_ table.
	
	3.1 Choose the _Customers_ table and run through the configuration.
	
	![alt text]({{ site.url }}/assets/3.1_source.PNG "Source")
	
	3.2 You do not have to _Add Profiling_.
	
	![alt text]({{ site.url }}/assets/3.2_profile.PNG "Profiling")
	
	3.3 This provides us with a process that does not do anything.
	
	![alt text]({{ site.url }}/assets/3.3_process1.PNG "Process")
	
4. Add another Reader for the _Employees_ table.

	4.1 Select the Data Store icon on the _Tool Palette_ and drag a **Reader** onto the process panel.
	
	![alt text]({{ site.url }}/assets/4.1_reader1.PNG "Reader Employees")
	
	4.2 Double click on the new Reader and select the _Employees_ snapshot at the Source dropdown. Select all fields for this exercise - we'll only be using country though.
	
	![alt text]({{ site.url }}/assets/4.2_reader2.PNG "Reader Employees")
	
5. Add an Advanced Matcher.

	5.1 Select the Matching icon on the _Tool Palette_ and drag an **Advanced Match** onto the process panel.
	
	![alt text]({{ site.url }}/assets/5.1_add_matcher.PNG "Advanced Matcher")

	5.2 Link the first **Reader** to the **Advanced Match** _Working Data_ port.
	
	![alt text]({{ site.url }}/assets/5.2_link_readers.PNG "Link Advanced Matcher")

	5.3 The configuration window will pop-up after the first link, choose the **City** attribute and add it to the _Selected Attributes_ list.
	 	 
	![alt text]({{ site.url }}/assets/5.3_setup_matcher1.PNG "Set Fields Advanced Matcher")
	
	5.4 _**Do not close the process tab**_  Close the _Advanced Match_ tab.
	
	![alt text]({{ site.url }}/assets/5.4_input_matcher.PNG "Set Fields Advanced Matcher")

	5.5 Link the remaining **Reader** to the **Advanced Match** _Reference Data_ port.

	![alt text]({{ site.url }}/assets/5.5_link_readers2.PNG "Link Advanced Matcher")

6. Configuring the **Advanced Match**.

	6.1 Once you link the second reader the **Advanced Match** configuration window opens. _Double Click_ on **Input** to open the input configuration.

	![alt text]({{ site.url }}/assets/6.1_setInput.PNG "Input for Advanced Matcher")

	6.1.1 Both the _Employees_ and _Customers_ sources should be available as Tabs at the top of the configuration window. Switch between the tabs and ensure the appropriate source is selected for each tab and that the **City** attribute is added to the _Selected Attributes_ list.
	
	![alt text]({{ site.url }}/assets/6.2_setInput2.PNG "Input for Advanced Matcher")

	6.1.2 This provides us with the following view displaying the two tables.
	
	![alt text]({{ site.url }}/assets/6.3_sources_set.PNG "Sources set for Advanced Matcher")
	
	6.2 Click on _Auto Map Identifies_ **OR** alternatively _Double Click_ on the **Identify** to map the identifiers manually.
	
	![alt text]({{ site.url }}/assets/6.4_map_identifiers.PNG "Map Identifiers")
	![alt text]({{ site.url }}/assets/6.4_map_identifiers1.PNG "Map Identifiers")

	6.3 _Double Click_ on [**Cluster**](http://www.oracle.com/webfolder/technetwork/data-quality/edqhelp/Content/advanced_features/indexing_concept_guide.htm) to create one.<sup><sup>[See the link for further information on **Clustering**](http://www.oracle.com/webfolder/technetwork/data-quality/edqhelp/Content/advanced_features/indexing_concept_guide.htm).</sup></sup> Click on the _+_ button > then _Add Identififer_ and select **City**.

	![alt text]({{ site.url }}/assets/6.5_cluster1.PNG "Cluster")
	
	6.4 _Double Click_ on **Match**
	
	![alt text]({{ site.url }}/assets/6.6_match1.PNG "Match")
	
	6.4.1 **City** will be available. Select **City** and click on _Add Comparison_.
	
	![alt text]({{ site.url }}/assets/6.6_match2.PNG "Comparison")
	
	6.4.2 Change the Comparison Type to _Exact String Match_.<sup><sup>Feel free to look through the other options that might come in handy in the dropdown.</sup></sup>
	
	![alt text]({{ site.url }}/assets/6.6_match3.PNG "Comparison")
	
	6.5 Switch to the _Match Rules_ tab and click on the _+_ button at the bottom left to add a match rule. Change the _Decision_ to **MATCH** and set the value for the Comparison configuration _Comparison1_ to **true**.<sup><sup>The _Matching Rules_ determine when and how to handle a comparison result. In this case we want it to be treated as a Match.</sup></sup>
	
	![alt text]({{ site.url }}/assets/6.7_match_rule.PNG "Comparison")
		
	6.6 Close the _Advanced Match_ tab.
	
	![alt text]({{ site.url }}/assets/5.4_input_matcher.PNG "Close Advanced Matcher Configuration")
	
7. Run the process.

	![alt text]({{ site.url }}/assets/7_run.PNG "Set Fields Advanced Matcher")

8. Evaluate the results.

	8.1 We have 8 Matches and clicking on the 8 provides us with a drill down into those 8 records.
	
	![alt text]({{ site.url }}/assets/8_results1.PNG "Advanced Matcher Matching")

	8.2 You can drill down into the data to see the relationships and which cities overlap.
	
	![alt text]({{ site.url }}/assets/8_results2.PNG "Drill down")

## Additional Information
* See the [Matching Concept Guide](http://www.oracle.com/webfolder/technetwork/data-quality/edqhelp/Content/advanced_features/matching_concept_guide.htm) for additional information.
* OEDQ is a great tool and is extremely powerful. For the data cleansing project I set up scheduled jobs that profile certain table fields for a degree of quality and produces a few Excel spreadsheet (per business area concerned) with the anomalous records to be addressed. The previous reports are archived and hence, an analysis can be done to determine if data quality is improving or degrading over time. All this was done with built in Functionality provided by OEDQ in conjuction with a few batch files for complex file system I/O operations.
* The documentation has some crucial information hidden (in a note sections or greyed out sections). However, it is helpful and does explain the reasoning behind the functionality and the operations one can perform.
_**This little snippet explained why I could not see any client side Data Stores in my Tool palette when creating a Job.**_
	
	[![alt text]({{ site.url }}/assets/oedq_note_ind.png "Crucial Information")][OEDQHelp]
	
# Version Information
	
![alt text]({{ site.url }}/assets/oedq_version.PNG "OEDQ Version")
	
## Moral:

So what can we take from Phil's infinite wisdom?

  * "You can tell a lot about a person from his Biography." — Phil Dunphy [Phil’s-osophy]
 
    **_Reading the help documentation helps..._**
 
 
[OEDQHelp]:http://www.oracle.com/webfolder/technetwork/data-quality/edqhelp/Content/concepts/jobs.htm