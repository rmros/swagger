//
// ModifiedQueue.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class ModifiedQueue: JSONEncodable {

    public var ACL: ACL?
    public var _type: String?
    public var expires: NSDate?
    public var queueType: String?
    public var retry: String?
    public var name: String?
    public var subscribers: [String]?
    public var isModified: Bool?
    public var modifiedColumns: [String]?
    public var messages: [QueueMessage]?
    

    public init() {}

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["ACL"] = self.ACL?.encodeToJSON()
        nillableDictionary["_type"] = self._type
        nillableDictionary["expires"] = self.expires?.encodeToJSON()
        nillableDictionary["queueType"] = self.queueType
        nillableDictionary["retry"] = self.retry
        nillableDictionary["name"] = self.name
        nillableDictionary["subscribers"] = self.subscribers?.encodeToJSON()
        nillableDictionary["_isModified"] = self.isModified
        nillableDictionary["_modifiedColumns"] = self.modifiedColumns?.encodeToJSON()
        nillableDictionary["messages"] = self.messages?.encodeToJSON()
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}