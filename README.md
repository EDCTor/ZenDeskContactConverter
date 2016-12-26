# ZenDeskContactConverter

ZenDeskContactConverter is a utility to translate your JSON contact export from Zen Desk (Zen) into a CSV file suitable for import back into Zen.  Why would you want to do this?  One scenario would be that you want to normalize or massage your contact data.  In my case, I needed to cleanup data imported into Zen.

Zen has a very complete API, but in my case, it was just easier to manipulate the data in Excel.  Getting the data from JSON into CSV was just the first step in my process.  Once the data was in CSV it was trivial for me to utilize Excel and macros to do the modifications that I required.

## How to Use

1). [Export from Zen](https://support.zendesk.com/hc/en-us/articles/203662346-Exporting-data-to-a-CSV-or-XML-file-Professional-and-Enterprise-)

2). Convert JSON to CSV

Download and compile the code, get the JSON.net library here: [http://www.newtonsoft.com/json](http://www.newtonsoft.com/json)

3). [Import CSV to Zen](https://support.zendesk.com/hc/en-us/articles/203661996-Bulk-importing-users-and-organizations)

## Samples

In the \resources directory is a sample.json and a sample.csv, to illustrate what the input and output files look like.

## Known Issues

1). No log output: in my case, I had 100% conversion the first time.  Since my conversion was finished, I had no incentive to add logging.

2). Configurable input and output files.  Adding a configuration to the GUI would be useful for future users.

3). No automatic header added to output CSV.  Zen requires a header in the CSV file.  In my case, I added the header after the fact.  As I had completed my task, I had no need to go back in and add this feature.  Suggested logic would be to check if the output csv existed, and if not, create the file with a header, otherwise append to the file.

4). Required fields check: my data did not violate any of the required field checks in Zen, but it would be useful to have the program check for required fields and then kick the records out that violated the requirements.

## Other

1). Zen does not allow you to export JSON data out of your help desk without contacting their support department.  For me, they responded within about 4 hours.

