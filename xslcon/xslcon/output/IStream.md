# HomeOS.Hub.Common.DataStore.IStream #
## Contents ##
- [Append(IKey, IValue)](#append_1)
- [Update(IKey, IValue)](#update_2)
- [Get(IKey)](#get_3)
- [GetLatest()](#getlatest_4)
- [GetAll(IKey)](#getall_5)
- [GetAll(IKey, Int64, Int64)](#getall_6)
- [GetKeys(IKey, IKey)](#getkeys_7)
- [DeleteStream()](#deletestream_8)
- [GrantReadAccess(String)](#grantreadaccess_9)
- [GrantReadAccess(String, String)](#grantreadaccess_10)
- [RevokeReadAccess(String)](#revokereadaccess_11)
- [RevokeReadAccess(String, String)](#revokereadaccess_12)
- [Flush()](#flush_13)
- [Close()](#close_14)
 
<a id="append_1"></a>
## Append(IKey, IValue) ##
 
Appends a new value to the specified key.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("myStream", false);
    StrKey key = new StrKey("myKey");
    StrValue val = new StrValue("myVal");
    datastream.Append(key, val);

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to update.|
|value|The value.|
 
 
----------
 
<a id="update_2"></a>
## Update(IKey, IValue) ##
 
Modifies the newest value for the specified key.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("myStream", false);
    StrKey key = new StrKey("myKey");
    StrValue val = new StrValue("myVal");
    datastream.Put(key, val);

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to update.|
|value|The value.|
 
 
----------
 
<a id="get_3"></a>
## Get(IKey) ##
 
Gets the newest value from the specified key.
 
**Returns**
An IValue containing the results.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("myStream", false);
    string result = datastream.Get("myKey");

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to query.|
 
 
----------
 
<a id="getlatest_4"></a>
## GetLatest() ##
 
Gets the newest [key, value, timestamp] tuple inserted.
 
**Returns**
The newest tuple (key, value, timestamp) that was inserted.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("myStream", false);
    Tuple result = datastream.GetLatest();

 
**Parameters**
None.
 
 
----------
 
<a id="getall_5"></a>
## GetAll(IKey) ##
 
Get all the [key, value, ts] tuples corresponding to the specified key.
 
**Returns**
An IEnumerable containing the results.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("myStream", false);
    IEnumerable result = datastream.GetAll("myKey");

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to query.|
 
 
----------
 
<a id="getall_6"></a>
## GetAll(IKey, Int64, Int64) ##
 
Get all the [key, value, timestamp] tuples in the given time range corresponding to the specified key.
 
**Returns**
An IEnumerable containing the results.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("myStream", false);
    DateTime fromTime = new DateTime(2001, 01, 01, 0, 0, 0, DateTimeKind.Utc);
    DateTime rightNow = DateTime.UtcNow;
    IEnumerable result = datastream.GetAll("myKey", fromTime, rightNow);

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to query.|
|startTimeStamp|The timestamp at which the range should begin.|
|endTimeStamp|The timestamp at which the range should end.|
 
 
----------
 
<a id="getkeys_7"></a>
## GetKeys(IKey, IKey) ##
 
Get a list of all keys in the specified key range.
 
**Returns**
A List containing the results.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("myStream", false);
    IKey startKey = new IKey("begin");
    IKey endKey = new IKey("end");
    List result = datastream.GetKeys(startKey, endKey);

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|startKey|The key at which the range should begin.|
|endKey|The key at which the range should end.|
 
 
----------
 
<a id="deletestream_8"></a>
## DeleteStream() ##
 
Deletes the current stream.
 
**Parameters**
None.
 
 
----------
 
<a id="grantreadaccess_9"></a>
## GrantReadAccess(String) ##
 
Grants read access to the app at the specified AppId.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|AppId|The AppId of the app to which read access should be granted.|
 
 
----------
 
<a id="grantreadaccess_10"></a>
## GrantReadAccess(String, String) ##
 
Grants read access to the app at the specified HomeId and AppId.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|HomeId|The HomeId of the app to which read access should be granted.|
|AppId|The AppId of the app to which read access should be granted.|
 
 
----------
 
<a id="revokereadaccess_11"></a>
## RevokeReadAccess(String) ##
 
Revokes read access from the app at the specified AppId.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|AppId|The AppId of the app from which read access should be revoked.|
 
 
----------
 
<a id="revokereadaccess_12"></a>
## RevokeReadAccess(String, String) ##
 
Revokes read access from the app at the specified HomeId and AppId.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|HomeId|The HomeId of the app from which read access should be revoked.|
|AppId|The AppId of the app from which read access should be revoked.|
 
 
----------
 
<a id="flush_13"></a>
## Flush() ##
 
Flushes the current stream from memory.
 
**Parameters**
None.
 
 
----------
 
<a id="close_14"></a>
## Close() ##
 
Closes the current stream.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
None.
 
 
----------
 

