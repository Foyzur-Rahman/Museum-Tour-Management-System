# Museum-Tour-Management-System
Group Name: TBC Limited  
Group Leader: Abdallah Ahmed - M00940645  
Secretary: Philip Griffin - M00961140  
Main Developer: Foyzur Rahman - M00948381   
Main Developer: Tamjid Karim - M00948372   
Code Tester: Tanweer Ali - M00946884

#MuseumTourManagement 

Code Demonstration: https://youtu.be/HImaW4GW0lw

** Code Developer and Contributors **

**Code Developers Tasks**
- Tamjid Karim (MH1969@live.mdx.ac.uk): Developed and Implemented 'ExpeditionForm', 'BookingsForm', 'CustomerForm' and half of the 'DashboardForm'.
- Foyzur Rahman (FR314@live.mdx.ac.uk): Developed and Implemented 'ManageEmployeesForm', 'EarningsForm', 'EmployeesForm' and the other half of the Dashboard Form

**Code Contributor and Tester**
- Tanweer Ali (TA938@live.mdx.ac.uk): Contributed with BookingsForm and some DashboardForm with Tamjid and Foyzur

#How to Compile and run the project

## 1.Setup the database

### Step 1. Open SQL Server Management Studio (SSMS)

### Step 2. Open SQL Statements and add every SQL Statement in the document

### Step 3. After completion move onto next part



## 2. Make sure the connection string is your computer and not my one in Database.cs

### Step 1. Click on Database.cs

### Step 2. Scroll at the very top and make sure this line "Server=DESKTOP-IJNILMU;Database=MuseumDB;Trusted_Connection=True;"; is your computer

### Step 3. You can check your computer info at the right side of SSMS.

###Step 4. Move onto next part when completed



## 3. Information on how the program works

## 3.1 Login
-- When running application you will be prompted to a login form, where you will need to input admin as username and admin123 as password. If inputted incorrectly a popup message will show 
-- When inputted correctly you will be welcomed to the dashboard and see icons and sidebar

## 3.2 Expeditions
-- At the sidebar, you will see expeditions. Click on expeditions and toggle through each event. Each event shows the scheduled time
-- Click on an event, at the bottom named 'Customers in Expedition' It will show the attendee name, contact email, the event that they are in and booking status to check whether they are confirmed or not
-- Every event will have the same outcome, play around with it
-- To go back simply click on the back button top left of the screen


## 3.3 Customers
-- Click on customers at the sidebar
-- When clicked You will see information of all of the customer name and email address
-- Click on the back button, the total number of customers also show in a small widget on the dashboard at the bottom left of the middle screen

## 3.4 Bookings
-- Click on bookings at the sidebar
--When clicked you will information of the ExpeditionID, Customer, Expedition (Event name they are in), Booking date, Time slot and the status
-- There is a filter system, simply filter dates to see a specific date from and when customers have booked from
-- For example try 10th February 2025 to 20th February 2025. You will now see filtered dates

## 3.5 Earnings 
-- Click on Earnings at the sidebar
-- At the top you can input numbers to show how much money you have made. When inputted it'll also show the date you have inputted it.
-- When inputted go back to dashboard to see that the number has been added to the widget on the dashboard widget called 'Revenue'
-- You can also delete the earnings. Simply click on a selected date and earning, and then delete selected earning, You will be prompted if you are sure to delete the earning.

## 3.6 Manage Employees
-- Click on Manage Employees at the sidebar
-- You can hire employee by clicking on hire employee. When clicked you will be prompted to enter employees name. Enter the employees name and click ok.
-- When clicked on ok, go back to dashboard, the widget called 'Employees will be incremented by 1'
-- Now click on the name you entered, then click on fire selected, you will then be prompted if you want to fire the name you have entered, click ok.
-- Now check widget it has removed 1 employee on the dashboard widget.

## 3.7
-- When finished you can logout.
-- When clicked on logout, you will then see our logo and your back to login screen

**End of readme File txt**







