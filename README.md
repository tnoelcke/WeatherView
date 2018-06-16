# Weather View

## Overview
The goal of this application is to download and create plots for what ever weather models I can get data from. Most of the weather models will be in the form of grib2 files. Currently I am aware of the following models:
- GFS
- NAM
- EMCWF
- UKMET

The models above are models I can get data for however these models may not be the most up to date models with out some sort of membership. If I think this application has the potential to make some money than I will consider buying the membership needed to produce the data.

In general this application will be divided into three sections. The front end, the API and the data maintainer. Below I will describe each.

### Front End
The front end is what you would expect. Its what the user sees and interacts with. This will be done using  reactJS. This will be served using a NodeJS app. This will be a fairly simple application that will display data to the user in a nice color coded spread sheet like format. I would also like the ability to support graph type data display formats. However the initial focus of development will be the spread sheet like display format.

### API
The api will serve the data. The api will be supplied a list of files containing the weather data. This will probably be in a GRIB2 format. However if i can find more data in a different format then I plan to support this data in that format using python if possible. I plan to use flask for this section of the project given that this will need to interface with GRIB2 files and the only acceptable library is in python. (There are other libraries but i don't want to use C++, JAVA or FORTRAN). This will be a simple rest API where i will make requests for data from the front end later.

### Data Maintainer
Given that the data changes often and not at predicable intervals I will also have a data maintainer service that will independently check and update the data if there is more up to date data. This will also be a flask API. Essentially, the API will make requests to this api to check that the data is up to date. If it is not than the maintainer will send the data is currently has along with a note that more up to date info will be available shortly. It will then download the data and replace the current out of date data. This is likely to be the largest technical challenge on this project.