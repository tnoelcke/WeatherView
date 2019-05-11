#!/bin/python
from ftplib import FTP
import datetime
#URL Constants
GFS_URL="ftp.nomads.ncdc.noaa.gov"
GFS_ENS_URL="ftp://nomads.ncdc.noaa.gov/GENS/"
NAM_URL="ftp://nomads.ncdc.noaa.gov/NAM/Grid218/"
EMCWF_URL="ftp://wmo:essential@dissemination.ecmwf.int/"
WAIT_TIME=60


def main():
    date = datetime.datetime.today()
    print(date)
    ftp = FTP(GFS_URL)
    ftp.login()
    ftp.retrlines("LIST")

main()