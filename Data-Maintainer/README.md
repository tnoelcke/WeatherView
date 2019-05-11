# Data Maintainer

## Setup

## Running server

## Description

This service will maintain the data in this system. This part of the system will be responsible for downloading and checking that the current data is the most up to date. This part of the system will reach out to the various data sources every 30 mins and ensure that the current data is the most up to date. If the data is out of date this service will pull the data from its source and will replace the current data set. I don't anticipate that this will be a large technical challenge given that this is essentially just a really fancy cron job.

## Data Sources

ECMWF - Operational (10 day) and ENS ftp://wmo:essential@dissemination.ecmwf.int/
GFS - Operational (10 Day) ftp://nomads.ncdc.noaa.gov/GFS/Grid4/
File Format - 
GFS Ensemble - ftp://nomads.ncdc.noaa.gov/GENS/
NAM - ftp://nomads.ncdc.noaa.gov/NAM/Grid218/