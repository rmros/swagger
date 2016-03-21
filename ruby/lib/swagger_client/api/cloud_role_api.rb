=begin
CloudBoost Application API

Power your web or mobile application backend with cloudboost Database Service

OpenAPI spec version: 1.0.0
Contact: ben@cloudboost.io
Generated by: https://github.com/swagger-api/swagger-codegen.git

License: MIT
http://opensource.org/licenses/MIT

Terms of Service: https://cloudboost.io

=end

require "uri"

module SwaggerClient
  class CloudRoleApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # create a new cloudrole
    # 
    # @param app_id ID of app
    # @param body request body
    # @param [Hash] opts the optional parameters
    # @return [CloudRole]
    def create_role(app_id, body, opts = {})
      data, status_code, headers = create_role_with_http_info(app_id, body, opts)
      return data
    end

    # create a new cloudrole
    # 
    # @param app_id ID of app
    # @param body request body
    # @param [Hash] opts the optional parameters
    # @return [Array<(CloudRole, Fixnum, Hash)>] CloudRole data, response status code and response headers
    def create_role_with_http_info(app_id, body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: CloudRoleApi#create_role ..."
      end
      
      # verify the required parameter 'app_id' is set
      fail "Missing the required parameter 'app_id' when calling create_role" if app_id.nil?
      
      # verify the required parameter 'body' is set
      fail "Missing the required parameter 'body' when calling create_role" if body.nil?
      
      # resource path
      local_var_path = "data/{app_id}/Role".sub('{format}','json').sub('{' + 'app_id' + '}', app_id.to_s)

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(body)
      
      auth_names = []
      data, status_code, headers = @api_client.call_api(:PUT, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'CloudRole')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: CloudRoleApi#create_role\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end