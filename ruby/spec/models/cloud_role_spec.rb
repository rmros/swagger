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

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::CloudRole
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'CloudRole' do
  before do
    # run before each test
    @instance = SwaggerClient::CloudRole.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of CloudRole' do
    it 'should create an instact of CloudRole' do
      @instance.should be_a(SwaggerClient::CloudRole) 
    end
  end
end

