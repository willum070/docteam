## HomeOS.Hub.Common.DataStore.IStream ##
- [Create()](#create)
- [Open()](#open)
- [Update(IKey, IValue)](#update)
- [Append(IKey, IValue)](#append)
- [Get(IKey)](#get)
- [GetLatest()](#getlatest)
- [GetAll(IKey)](#getall)
- [GetAll(IKey, Int64, Int64)](#getall)
- [GetKeys(IKey, IKey)](#getkeys)
- [DeleteStream()](#deletestream)
- [GrantReadAccess(String)](#grantreadaccess)
- [GrantReadAccess(String, String)](#grantreadaccess)
- [RevokeReadAccess(String)](#revokereadaccess)
- [RevokeReadAccess(String, String)](#revokereadaccess)
- [Flush()](#flush)
- [Close()](#close)

### Create() ###
 
Creates a new data stream.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
None.
 
 
----------
 
### Open() ###
 
Opens a data stream.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
None.
 
 
----------
 
### Update(IKey, IValue) ###
 
Modifies the newest entry in a key.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("dumb", false /* remoteSync */);
    StrKey key = new StrKey("DummyKey");
    StrValue val = new StrValue("DummyVal");
    datastream.Put(key, val);

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to update.|
|value|The value.|
 
 
----------
 
### Append(IKey, IValue) ###
 
Appends a new value to a key.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("dumb", false /* remoteSync */);
    StrKey key = new StrKey("DummyKey");
    StrValue val = new StrValue("DummyVal");
    datastream.Append(key, val);

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to update.|
|value|The value.|
 
 
----------
 
### Get(IKey) ###
 
Gets the newest value for the specified key.
 
**Returns**
An IValue containing the results.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("dumb", false /* remoteSync */);
    string result = datastream.Get("DummyKey");

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to query.|
 
 
----------
 
### GetLatest() ###
 
Gets the newest [key, value, timestamp] tuple inserted.
 
**Returns**
The newest tuple (key, value, timestamp) that was inserted.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("dumb", false /* remoteSync */);
    Tuple result = datastream.GetLatest();

 
**Parameters**
None.
 
 
----------
 
### GetAll(IKey) ###
 
Get all the [key, value, ts] tuples corresponding to the specified key.
 
**Returns**
An IEnumerable containing the results.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("dumb", false /* remoteSync */);
    IEnumerable result = datastream.GetAll("DummyKey");

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to query.|
 
 
----------
 
### GetAll(IKey, Int64, Int64) ###
 
Get all the [key, value, timestamp] tuples in the given time range corresponding to the specified key.
 
**Returns**
An IEnumerable containing the results.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("dumb", false /* remoteSync */);
    IEnumerable result = datastream.GetAll("DummyKey", ???, ???);

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|key|The key to query.|
|startTimeStamp|A timestamp indicating the start of the time range.|
|endTimeStamp|A timestamp indicating the end of the time range.|
 
 
----------
 
### GetKeys(IKey, IKey) ###
 
Get a list of all keys in the specified key range.
 
**Returns**
A List containing the results.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("dumb", false /* remoteSync */);
    IKey startKey = new IKey("begin");
    IKey endKey = new IKey("end");
    List result = datastream.GetKeys(startKey, endKey);

 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|startKey|A key indicating the beginning of the key range.|
|endKey|A key indicating the end of the key range.|
 
 
----------
 
### DeleteStream() ###
 
Deletes the current stream.
 
**Parameters**
None.
 
 
----------
 
### GrantReadAccess(String) ###
 
Grants read access to the app at the specified AppId.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|AppId|The AppId of the app to which read access should be granted.|
 
 
----------
 
### GrantReadAccess(String, String) ###
 
Grants read access to the app at the specified HomeId and AppId.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|HomeId|The HomeId of the app to which read access should be granted.|
|AppId|The AppId of the app to which read access should be granted.|
 
 
----------
 
### RevokeReadAccess(String) ###
 
Revokes read access from the app at the specified AppId.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|AppId|The AppId of the app from which read access should be revoked.|
 
 
----------
 
### RevokeReadAccess(String, String) ###
 
Revokes read access from the app at the specified HomeId and AppId.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|HomeId|The HomeId of the app from which read access should be revoked.|
|AppId|The AppId of the app from which read access should be revoked.|
 
 
----------
 
### Flush() ###
 
Flushes the current stream from memory.
 
**Parameters**
None.
 
 
----------
 
### Close() ###
 
Closes the current stream.
 
**Returns**
A boolean indicating success or failure.
 
**Parameters**
None.
 
 
----------
 

