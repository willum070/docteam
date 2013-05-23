# ChronoZoom REST API Reference #

The ChronoZoom Representational State Transfer (REST) API makes it possible to programmatically access content within a given ChronoZoom deployment. All request data is in JavaScript Object Notation (JSON) format. This document describes how to make REST requests against ChronoZoom.

## Request Syntax ##
ChronoZoom REST requests use standard HTTP verbs (GET, PUT, DELETE). Request URLs point to **chronozoom.svc** for the deployment, followed by the supercollection and collection names, and finally the resource type:

    http://[site URL]/chronozoom.svc/[superCollectionName]/[collectionName]/[resource]

The request body is in JSON format:
    
    {
        id: "0123456789"
    }

## Contents ##
- [ChronoZoom Entities](#chronozoom-entities)
- [ChronoZoom REST Commands](#chronozoom-rest-commands)

## ChronoZoom Entities ##
- [BookmarkType](#bookmarktype)
- [Bookmark](#bookmark)
- [Collection](#collection)
- [ContentItem](#contentitem)
- [Exhibit](#exhibit)
- [RemoveBetaFields](#removebetafields)
- [RemoveRITree](#removeritree)
- [AddRITreeWithIndex](#addritreewithindex)
- [ObjectType](#objecttype)
- [SearchResult](#searchresult)
- [Storage](#storage)
- [StorageMigrationsConfiguration](#storagemigrationsconfiguration)
- [SuperCollection](#supercollection)
- [User](#user)

### BookmarkType ###
 
Specifies the type of bookmark.
 
|Enum|Value|
|:--------|:----|
|Timeline|0|
|Exhibit|1|
|ContentItem|2|
 
### Bookmark ###
 
Specifies a tour stop (can be either a timeline, an exhibit, or a content item).
 
|Property|Value|
|:-------|:----|
|Id|The ID of the bookmark.|
|Name|The name of the bookmark.|
|Url|The URL of the bookmark.|
|ReferenceType|The type of reference for the bookmark.|
|ReferenceId|The ID of the reference that is associated with the bookmark.|
|LapseTime|The lapse time value for the bookmark.|
|Description|A text description of the bookmark.|
 
### Collection ###
 
Represents a collection of timelines.
 
|Property|Value|
|:-------|:----|
|Id|The ID of the collection.|
|Title|The title of the collection.|
|User|The user ID for the collection owner.|
 
### ContentItem ###
 
A pointer to a piece of content in ChronoZoom. The Content Item entity is contained by an Exhibit, and is only viewable as part of an Exhibit.
 
|Property|Value|
|:-------|:----|
|Id|The ID of the content item.|
|Depth|The depth of the content item in the timeline tree|
|Title|The title of the content item.|
|Caption|The description of the content item.|
|Year|The year in which the content item appears.|
|MediaType|Specifies which type of media the content type is.|
|Uri|The URL for the content item.|
|MediaSource|Identifies the source of the content item.|
|Attribution|The attribution for the content item.|
|Order|Specifies the order in which the content item should appear.|
|Collection|The collection that the content item is associated with.|
 
### Exhibit ###
 
Contains a set of content items, and is contained by a timeline or a collection.
 
|Property|Value|
|:-------|:----|
|Id|The ID of the exhibit.|
|Depth|The depth of the exhibit in the timeline tree|
|Title|The title of the exhibit.|
|ContentItems|Specifies the collection of content items that is associated with the exhibit.|
|Collection|Specifies the collection that is associated with the exhibit.|
 
### RemoveBetaFields ###
 
Migration to remove beta fields.
 
 
### RemoveRITree ###
 
Migration to remove the RI-Tree.
 
 
### AddRITreeWithIndex ###
 
Migration to add RI-Tree with index field.
 
 
### ObjectType ###
 
Specifies the type of object contained by the search result.
 
|Enum|Value|
|:--------|:----|
|Exhibit|0|
|Timeline|1|
|ContentItem|2|
 
### SearchResult ###
 
Contains a search result.
 
|Property|Value|
|:-------|:----|
|Id|The ID of the search result.|
|Title|The title of the search result.|
|ObjectType|The type of object contained by the search result.|
 
### Storage ###
 
Storage implementation for ChronoZoom based on Entity Framework.
 
 
### StorageMigrationsConfiguration ###
 
Describes storage migration options. Used when a schema upgrade is required.
 
 
### SuperCollection ###
 
Represents a set of collections.
 
|Property|Value|
|:-------|:----|
|Id|The ID of the supercollection.|
|Title|The title of the supercollection.|
|User|The user who owns the supercollection.|
|Collections|A collection of collections that belong to the supercollection.|
 
### User ###
 
A registered user.
 
|Property|Value|
|:-------|:----|
|Id|The ID of the user.|
|DisplayName|The display name of the user.|
|Email|The email address of the user.|
 

## ChronoZoom REST Commands ##
- [GetTimelines](#gettimelines)
- [Search](#search)
- [GetDefaultTours](#getdefaulttours)
- [GetTours](#gettours)
- [PutUser](#putuser)
- [GetServiceInformation](#getserviceinformation)
- [DeleteUser](#deleteuser)
- [GetUser](#getuser)
- [PutCollectionName](#putcollectionname)
- [DeleteCollection](#deletecollection)
- [PutTimeline](#puttimeline)
- [DeleteTimeline](#deletetimeline)
- [PutExhibit](#putexhibit)
- [DeleteExhibit](#deleteexhibit)
- [PutContentItem](#putcontentitem)
- [DeleteContentItem](#deletecontentitem)
- [GetContentPath](#getcontentpath)
- [GetCollections](#getcollections)

### GetTimelines ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### Search ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### GetDefaultTours ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### GetTours ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### PutUser ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### GetServiceInformation ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### DeleteUser ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### GetUser ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### PutCollectionName ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### DeleteCollection ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### PutTimeline ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### DeleteTimeline ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### PutExhibit ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### DeleteExhibit ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### PutContentItem ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### DeleteContentItem ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### GetContentPath ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 
### GetCollections ###
 
Documentation under IChronozoomSVC
 
**Parameters**
None.
 
 
[top](#chronozoom-rest-api-reference)
 
----------
 

