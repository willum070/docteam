## HomeOS.Hub.Common.DataStore.IStream ##
- [Update](#update)
- [Append](#append)
- [Get](#get)
- [GetLatest](#getlatest)
- [GetAll](#getall)
- [GetAll](#getall)
- [GetKeys](#getkeys)
- [DeleteStream](#deletestream)
- [GrantReadAccess](#grantreadaccess)
- [RevokeReadAccess](#revokereadaccess)
- [Flush](#flush)
- [Close](#close)

### Update ###
 
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
 
### Append ###
 
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
 
### Get ###
 
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
 
### GetLatest ###
 
Gets the latest [key, value, timestamp] tuple inserted.
 
**Returns**
The newest tuple (key, value, timestamp) that was inserted.
 
**Example**

    IStream datastream;
    datastream = base.CreateFileStream<StrKey, StrValue>("dumb", false /* remoteSync */);
    Tuple result = datastream.GetLatest();

 
**Parameters**
None.
 
 
----------
 
### GetAll ###
 
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
 
### GetAll ###
 
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
 
### GetKeys ###
 
Get all keys in the specified key range.
 
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
 
### DeleteStream ###
 
Deletes the current stream.
 
**Parameters**
None.
 
 
----------
 
### GrantReadAccess ###
 
Grants read access to the app at the specified AppId.
 
**Returns**
A boolean indicating whether the operation succeeded.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|AppId|The AppId of the app to which read access should be granted.|
 
 
----------
 
### RevokeReadAccess ###
 
Revokes read access from the app at the specified AppId.
 
**Returns**
A boolean indicating whether the operation succeeded.
 
**Parameters**
 
|Parameter|Value|
|:--------|:----|
|AppId|The AppId of the app from which read access should be revoked.|
 
 
----------
 
### Flush ###
 
Grants write access to the app at the specified AppId.
 
**Parameters**
None.
 
 
----------
 
### Close ###
 
Closes the current stream.
 
**Returns**
A boolean indicating whether the operation succeeded.
 
**Parameters**
None.
 
 
----------
 

