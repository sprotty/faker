# frozen_string_literal: true

require_relative 'test_helper'
require 'json'

class TestArLocale < Test::Unit::TestCase
  def setup
    Faker::Config.locale = :ar
  end

  def teardown
    Faker::Config.locale = nil
  end

  def find_classes(mod)
    class_names = mod.constants.select {|c| mod.const_get(c).is_a? Class}
    json_classes = class_names.map{|cn| {
      "name":cn,
      "methods": find_methods(mod.const_get(cn)),
      "classes": find_classes(mod.const_get(cn)) }}
    return json_classes
  end

  def find_methods(class_info)
    json_methods = class_info.singleton_methods(false).map{ |mn| {"name":mn, "parameters": class_info.singleton_method(mn).parameters.map{|mi| find_parameters(mi)} }}
    return json_methods
      #
  end
  def find_parameters(parameter_info)
    {
      "name": parameter_info[1],
      "info": parameter_info[0],
    }
  end

  def test_ar_address_methods

    faker_model = { "classes": find_classes(Faker) }
    File.open('out.json', 'w') do |f|
      f.write(faker_model.to_json)
    end

    # for class_name in Faker.constants.select {|c| Faker.const_get(c).is_a? Class} do
    #  puts "class : %s" % class_name
    #  class_info = Faker.const_get(class_name)
    #  for method_name in class_info.singleton_methods(false) do
    #    puts "    method %s" % method_name
    #    method = class_info.singleton_method(method_name)
    #    for param_info in method.parameters do
    #      puts "       %s (%s)" % [ param_info[1], param_info[0]]
    #    end
    #  end
    #end


    assert Faker::Address.country.is_a? String
    assert Faker::Address.city.is_a? String
    assert Faker::Address.street_name.is_a? String
    assert Faker::Address.street_address.is_a? String
    assert Faker::Address.full_address.is_a? String
    assert Faker::Address.zip_code.is_a? String
    assert Faker::Address.secondary_address.is_a? String
    assert Faker::Address.postcode.is_a? String
    assert Faker::Address.city_name.is_a? String
    assert Faker::Address.building_number.is_a? String
    assert Faker::Address.street_address.is_a? String
    assert Faker::Address.full_address.is_a? String
    assert Faker::Address.default_country.is_a? String
    assert_equal('المملكة العربية السعودية', Faker::Address.default_country)
  end

  def test_ar_app_methods
    assert Faker::App.name.is_a? String
    assert Faker::App.version.is_a? String
    assert Faker::App.author.is_a? String
  end

  def test_ar_book_methods
    assert Faker::Book.title.is_a? String
    assert Faker::Book.author.is_a? String
    assert Faker::Book.publisher.is_a? String
    assert Faker::Book.genre.is_a? String
  end

  def test_ar_color_name
    assert Faker::Color.color_name.is_a? String
  end

  def test_ar_commerce_methods
    assert Faker::Commerce.department.is_a? String
    assert Faker::Commerce.product_name.is_a? String
    assert Faker::Commerce.promotion_code.is_a? String
  end

  def test_ar_company_methods
    assert Faker::Company.name.is_a? String
    assert Faker::Company.industry.is_a? String
    assert Faker::Company.profession.is_a? String
    assert Faker::Company.suffix.is_a? String
    assert Faker::Company.buzzword.is_a? String
    assert Faker::Company.bs.is_a? String
  end

  def test_ar_name_methods
    assert Faker::Name.first_name.is_a? String
    assert Faker::Name.last_name.is_a? String
    assert Faker::Name.name_with_middle.is_a? String
    assert Faker::Name.prefix.is_a? String
  end

  def test_ar_team_methods
    assert Faker::Team.creature.is_a? String
    assert Faker::Team.name.is_a? String
    assert Faker::Team.sport.is_a? String
  end

  def test_ar_university_methods
    assert Faker::University.name.is_a? String
    assert Faker::University.prefix.is_a? String
    assert Faker::University.suffix.is_a? String
  end
end
