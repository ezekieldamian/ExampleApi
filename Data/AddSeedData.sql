/*
Run this script on:

localhost,1433.dev_e    -  This database will be modified

to synchronize it with:

devqaods.public.db3ff159d301.database.windows.net, 3342.dev_db

You are recommended to back up your database before running this script

Script created by SQL Data Compare version 14.4.4.16824 from Red Gate Software Ltd at 11/23/2020 2:47:06 AM

*/
		
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
GO
SET DATEFORMAT YMD
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL Serializable
GO
BEGIN TRANSACTION

PRINT(N'Drop constraints from [ods].[professional_service]')
ALTER TABLE [ods].[professional_service] NOCHECK CONSTRAINT [fk_service_product]

PRINT(N'Drop constraint fk_business_location_service_service from [ods].[business_location_service]')
ALTER TABLE [ods].[business_location_service] NOCHECK CONSTRAINT [fk_business_location_service_service]

PRINT(N'Drop constraint fk_businss_location_work_space_service from [ods].[business_location_service_bay_service]')
ALTER TABLE [ods].[business_location_service_bay_service] NOCHECK CONSTRAINT [fk_businss_location_work_space_service]

PRINT(N'Drop constraint fk_employee_service_qualification_service from [ods].[mobile_business_employee_service_qualification]')
ALTER TABLE [ods].[mobile_business_employee_service_qualification] NOCHECK CONSTRAINT [fk_employee_service_qualification_service]

PRINT(N'Drop constraint fk_retail_customer_service_calendar_preference_service from [ods].[retail_customer_service_calendar_preference]')
ALTER TABLE [ods].[retail_customer_service_calendar_preference] NOCHECK CONSTRAINT [fk_retail_customer_service_calendar_preference_service]

PRINT(N'Drop constraint fk_retail_customer_service_location_preference_service from [ods].[retail_customer_service_location_preference]')
ALTER TABLE [ods].[retail_customer_service_location_preference] NOCHECK CONSTRAINT [fk_retail_customer_service_location_preference_service]

PRINT(N'Drop constraint fk_retail_customer_service_sd_preference_service from [ods].[retail_customer_service_special_duration]')
ALTER TABLE [ods].[retail_customer_service_special_duration] NOCHECK CONSTRAINT [fk_retail_customer_service_sd_preference_service]

PRINT(N'Drop constraint fk_retail_customer_servicer_preference_service from [ods].[retail_customer_servicer_preference]')
ALTER TABLE [ods].[retail_customer_servicer_preference] NOCHECK CONSTRAINT [fk_retail_customer_servicer_preference_service]

PRINT(N'Drop constraints from [ods].[good]')
ALTER TABLE [ods].[good] NOCHECK CONSTRAINT [fk_good_manufacturer]
ALTER TABLE [ods].[good] NOCHECK CONSTRAINT [fk_good_product]
ALTER TABLE [ods].[good] NOCHECK CONSTRAINT [fk_good_return_address]

PRINT(N'Drop constraint fk_business_location_inventory_good from [ods].[business_location_inventory]')
ALTER TABLE [ods].[business_location_inventory] NOCHECK CONSTRAINT [fk_business_location_inventory_good]

PRINT(N'Drop constraint fk_rentable_good_good from [ods].[rentable_good]')
ALTER TABLE [ods].[rentable_good] NOCHECK CONSTRAINT [fk_rentable_good_good]

PRINT(N'Drop constraint fk_good_vendor_order_good from [ods].[good_vendor_order]')
ALTER TABLE [ods].[good_vendor_order] NOCHECK CONSTRAINT [fk_good_vendor_order_good]

PRINT(N'Drop constraints from [ods].[product]')
ALTER TABLE [ods].[product] NOCHECK CONSTRAINT [fk_product_mobile_business]
ALTER TABLE [ods].[product] NOCHECK CONSTRAINT [fk_product_product_retail_category]
ALTER TABLE [ods].[product] NOCHECK CONSTRAINT [fk_product_tax_item_type]

PRINT(N'Drop constraint fk_asset_product from [ods].[asset]')
ALTER TABLE [ods].[asset] NOCHECK CONSTRAINT [fk_asset_product]

PRINT(N'Drop constraint fk_auction_item_product from [ods].[auction_item]')
ALTER TABLE [ods].[auction_item] NOCHECK CONSTRAINT [fk_auction_item_product]

PRINT(N'Drop constraint fk_auction_product_sugestion_product from [ods].[auction_product_sugestion]')
ALTER TABLE [ods].[auction_product_sugestion] NOCHECK CONSTRAINT [fk_auction_product_sugestion_product]

PRINT(N'Drop constraint fk_cart_item_product from [ods].[cart_product]')
ALTER TABLE [ods].[cart_product] NOCHECK CONSTRAINT [fk_cart_item_product]

PRINT(N'Drop constraint fk_dimensional_product_inventory_product from [ods].[dimension_dependent_inventory_record]')
ALTER TABLE [ods].[dimension_dependent_inventory_record] NOCHECK CONSTRAINT [fk_dimensional_product_inventory_product]

PRINT(N'Drop constraint fk_product_product_dimension_product from [ods].[product_applicable_dimension]')
ALTER TABLE [ods].[product_applicable_dimension] NOCHECK CONSTRAINT [fk_product_product_dimension_product]

PRINT(N'Drop constraint fk_product_customer_review_product from [ods].[product_customer_review]')
ALTER TABLE [ods].[product_customer_review] NOCHECK CONSTRAINT [fk_product_customer_review_product]

PRINT(N'Drop constraint Fk_product_image_product from [ods].[product_image]')
ALTER TABLE [ods].[product_image] NOCHECK CONSTRAINT [Fk_product_image_product]

PRINT(N'Drop constraint fk_product_quantity_discount_product from [ods].[product_quantity_discount]')
ALTER TABLE [ods].[product_quantity_discount] NOCHECK CONSTRAINT [fk_product_quantity_discount_product]

PRINT(N'Drop constraint fk_product_subscription_product from [ods].[product_subscription]')
ALTER TABLE [ods].[product_subscription] NOCHECK CONSTRAINT [fk_product_subscription_product]

PRINT(N'Drop constraint fk_product_tag_product from [ods].[product_tag]')
ALTER TABLE [ods].[product_tag] NOCHECK CONSTRAINT [fk_product_tag_product]

PRINT(N'Drop constraint fk_product_terms_product from [ods].[product_terms]')
ALTER TABLE [ods].[product_terms] NOCHECK CONSTRAINT [fk_product_terms_product]

PRINT(N'Drop constraint Fk_product_virtue_point_credit_product from [ods].[product_virtue_point_credit]')
ALTER TABLE [ods].[product_virtue_point_credit] NOCHECK CONSTRAINT [Fk_product_virtue_point_credit_product]

PRINT(N'Drop constraint fk_recomendation_product from [ods].[recommendation]')
ALTER TABLE [ods].[recommendation] NOCHECK CONSTRAINT [fk_recomendation_product]

PRINT(N'Drop constraint fk_restock_event_product from [ods].[restock_event]')
ALTER TABLE [ods].[restock_event] NOCHECK CONSTRAINT [fk_restock_event_product]

PRINT(N'Drop constraint fk_restock_requirement_product from [ods].[restock_requirement]')
ALTER TABLE [ods].[restock_requirement] NOCHECK CONSTRAINT [fk_restock_requirement_product]

PRINT(N'Drop constraint fk_retail_customer_favorite_product_product from [ods].[retail_customer_favorite_product]')
ALTER TABLE [ods].[retail_customer_favorite_product] NOCHECK CONSTRAINT [fk_retail_customer_favorite_product_product]

PRINT(N'Drop constraint Fk_trusted_trade_prompt_product_product from [ods].[trusted_trade_prompt_product]')
ALTER TABLE [ods].[trusted_trade_prompt_product] NOCHECK CONSTRAINT [Fk_trusted_trade_prompt_product_product]

PRINT(N'Drop constraint fk_universal_item_source from [ods].[universal_item_source]')
ALTER TABLE [ods].[universal_item_source] NOCHECK CONSTRAINT [fk_universal_item_source]

PRINT(N'Drop constraint fk_wishlist_product from [ods].[wishlist]')
ALTER TABLE [ods].[wishlist] NOCHECK CONSTRAINT [fk_wishlist_product]

PRINT(N'Drop constraints from [ods].[mobile_business_business_category]')
ALTER TABLE [ods].[mobile_business_business_category] NOCHECK CONSTRAINT [Fk_mobile_business_business_category_business_category]
ALTER TABLE [ods].[mobile_business_business_category] NOCHECK CONSTRAINT [Fk_mobile_business_business_category_mobile_business]

PRINT(N'Drop constraints from [ods].[business_location]')
ALTER TABLE [ods].[business_location] NOCHECK CONSTRAINT [fk_business_location_mobile_business]
ALTER TABLE [ods].[business_location] NOCHECK CONSTRAINT [Fk_business_location_post_office_address]

PRINT(N'Drop constraint fk_appointment_reschedule_alternative_business_location from [ods].[appointment_reschedule_alternative]')
ALTER TABLE [ods].[appointment_reschedule_alternative] NOCHECK CONSTRAINT [fk_appointment_reschedule_alternative_business_location]

PRINT(N'Drop constraint fk_location_contact_mechanism_business_location from [ods].[business_location_contact_mechanism]')
ALTER TABLE [ods].[business_location_contact_mechanism] NOCHECK CONSTRAINT [fk_location_contact_mechanism_business_location]

PRINT(N'Drop constraint fk_business_loation_hours_of_operation_business_location from [ods].[business_location_hours_of_operation]')
ALTER TABLE [ods].[business_location_hours_of_operation] NOCHECK CONSTRAINT [fk_business_loation_hours_of_operation_business_location]

PRINT(N'Drop constraint fk_business_location_inventory_business_location from [ods].[business_location_inventory]')
ALTER TABLE [ods].[business_location_inventory] NOCHECK CONSTRAINT [fk_business_location_inventory_business_location]

PRINT(N'Drop constraint fk_business_location_manager_business_location from [ods].[business_location_manager]')
ALTER TABLE [ods].[business_location_manager] NOCHECK CONSTRAINT [fk_business_location_manager_business_location]

PRINT(N'Drop constraint fk_business_location_service_business_location from [ods].[business_location_service]')
ALTER TABLE [ods].[business_location_service] NOCHECK CONSTRAINT [fk_business_location_service_business_location]

PRINT(N'Drop constraint fk_business_sub_location_business_location from [ods].[business_location_service_bay]')
ALTER TABLE [ods].[business_location_service_bay] NOCHECK CONSTRAINT [fk_business_sub_location_business_location]

PRINT(N'Drop constraint fk_business_location_staff_business_location from [ods].[business_location_staff]')
ALTER TABLE [ods].[business_location_staff] NOCHECK CONSTRAINT [fk_business_location_staff_business_location]

PRINT(N'Drop constraint fk_cart_business_location from [ods].[cart]')
ALTER TABLE [ods].[cart] NOCHECK CONSTRAINT [fk_cart_business_location]

PRINT(N'Drop constraint fk_mobile_business_employee_location_assignment_location_0 from [ods].[mobile_business_employee_location_fillin]')
ALTER TABLE [ods].[mobile_business_employee_location_fillin] NOCHECK CONSTRAINT [fk_mobile_business_employee_location_assignment_location_0]

PRINT(N'Drop constraint fk_retail_customer_service_location_preference_location from [ods].[retail_customer_service_location_preference]')
ALTER TABLE [ods].[retail_customer_service_location_preference] NOCHECK CONSTRAINT [fk_retail_customer_service_location_preference_location]

PRINT(N'Drop constraints from [ods].[state_or_province]')
ALTER TABLE [ods].[state_or_province] NOCHECK CONSTRAINT [Fk_state_or_province_country]

PRINT(N'Drop constraints from [ods].[post_office_address]')
ALTER TABLE [ods].[post_office_address] NOCHECK CONSTRAINT [fk_address_contact_mechansim]

PRINT(N'Drop constraint Fk_cart_shipping_address_fk from [ods].[cart]')
ALTER TABLE [ods].[cart] NOCHECK CONSTRAINT [Fk_cart_shipping_address_fk]

PRINT(N'Drop constraint fk_cleansed_address_provided_address from [ods].[cleansed_address]')
ALTER TABLE [ods].[cleansed_address] NOCHECK CONSTRAINT [fk_cleansed_address_provided_address]

PRINT(N'Drop constraint fk_mobile_business_return_address from [ods].[mobile_business]')
ALTER TABLE [ods].[mobile_business] NOCHECK CONSTRAINT [fk_mobile_business_return_address]

PRINT(N'Drop constraint Fk_retail_customer_saved_credit_card_post_office_address from [ods].[party_saved_credit_card]')
ALTER TABLE [ods].[party_saved_credit_card] NOCHECK CONSTRAINT [Fk_retail_customer_saved_credit_card_post_office_address]

PRINT(N'Drop constraint fk_product_retail_category_return_address from [ods].[product_retail_category]')
ALTER TABLE [ods].[product_retail_category] NOCHECK CONSTRAINT [fk_product_retail_category_return_address]

PRINT(N'Drop constraint fk_product_subscription_delivery_address from [ods].[product_subscription]')
ALTER TABLE [ods].[product_subscription] NOCHECK CONSTRAINT [fk_product_subscription_delivery_address]

PRINT(N'Drop constraints from [ods].[platform_virtue_grade]')
ALTER TABLE [ods].[platform_virtue_grade] NOCHECK CONSTRAINT [Fk_platform_virtue_grade_virtue]

PRINT(N'Drop constraint fk_mobile_business_loyalty_grade_threshold_platform_loyalty_grade from [ods].[mobile_business_loyalty_grade_threshold]')
ALTER TABLE [ods].[mobile_business_loyalty_grade_threshold] NOCHECK CONSTRAINT [fk_mobile_business_loyalty_grade_threshold_platform_loyalty_grade]

PRINT(N'Drop constraints from [ods].[platform_objective]')
ALTER TABLE [ods].[platform_objective] NOCHECK CONSTRAINT [Fk_platform_objective_platform_participation_type]

PRINT(N'Drop constraint Fk_party_platform_objective_priorityPlatform_objective from [ods].[party_platform_objective_priority]')
ALTER TABLE [ods].[party_platform_objective_priority] NOCHECK CONSTRAINT [Fk_party_platform_objective_priorityPlatform_objective]

PRINT(N'Drop constraints from [ods].[party_contact_mechanism]')
ALTER TABLE [ods].[party_contact_mechanism] NOCHECK CONSTRAINT [fk_party_contact_mechanism_contact_mechanism]
ALTER TABLE [ods].[party_contact_mechanism] NOCHECK CONSTRAINT [fk_party_contact_mechanism_party]

PRINT(N'Drop constraint Fk_cart_points_awarded_virtue from [ods].[cart_points_awarded]')
ALTER TABLE [ods].[cart_points_awarded] NOCHECK CONSTRAINT [Fk_cart_points_awarded_virtue]

PRINT(N'Drop constraint fk_mobile_business_ranking_of_virtues_vurtue from [ods].[mobile_business_virtue_ranking]')
ALTER TABLE [ods].[mobile_business_virtue_ranking] NOCHECK CONSTRAINT [fk_mobile_business_ranking_of_virtues_vurtue]

PRINT(N'Drop constraint Fk_mobile_business_virtue_score_virtue from [ods].[mobile_business_virtue_score]')
ALTER TABLE [ods].[mobile_business_virtue_score] NOCHECK CONSTRAINT [Fk_mobile_business_virtue_score_virtue]

PRINT(N'Drop constraint Fk_product_virtue_point_credit_virtue from [ods].[product_virtue_point_credit]')
ALTER TABLE [ods].[product_virtue_point_credit] NOCHECK CONSTRAINT [Fk_product_virtue_point_credit_virtue]

PRINT(N'Drop constraint Fk_retail_customer_virtue_points_virtue from [ods].[retail_customer_virtue_points]')
ALTER TABLE [ods].[retail_customer_virtue_points] NOCHECK CONSTRAINT [Fk_retail_customer_virtue_points_virtue]

PRINT(N'Drop constraint Fk_universal_virtue_grade_virtue from [ods].[universal_virtue_grade]')
ALTER TABLE [ods].[universal_virtue_grade] NOCHECK CONSTRAINT [Fk_universal_virtue_grade_virtue]

PRINT(N'Drop constraint Fk_trusted_trade_prompt_trusted_trade_type from [ods].[trusted_trade_prompt]')
ALTER TABLE [ods].[trusted_trade_prompt] NOCHECK CONSTRAINT [Fk_trusted_trade_prompt_trusted_trade_type]

PRINT(N'Drop constraint Fk_mobile_business_transaction_per_month_bracket from [ods].[mobile_business]')
ALTER TABLE [ods].[mobile_business] NOCHECK CONSTRAINT [Fk_mobile_business_transaction_per_month_bracket]

PRINT(N'Drop constraint Fk_mobile_business_transaction_size_bracket from [ods].[mobile_business]')
ALTER TABLE [ods].[mobile_business] NOCHECK CONSTRAINT [Fk_mobile_business_transaction_size_bracket]

PRINT(N'Drop constraint fk_mobile_buisness from [ods].[mobile_business]')
ALTER TABLE [ods].[mobile_business] NOCHECK CONSTRAINT [fk_mobile_buisness]

PRINT(N'Drop constraint fk_product_category_tax_item_type from [ods].[product_retail_category]')
ALTER TABLE [ods].[product_retail_category] NOCHECK CONSTRAINT [fk_product_category_tax_item_type]

PRINT(N'Drop constraint Fk_mobile_business_service_area_bracket from [ods].[mobile_business]')
ALTER TABLE [ods].[mobile_business] NOCHECK CONSTRAINT [Fk_mobile_business_service_area_bracket]

PRINT(N'Drop constraint Fk_party_language_preference_platform_supported_language from [ods].[party_language_preference]')
ALTER TABLE [ods].[party_language_preference] NOCHECK CONSTRAINT [Fk_party_language_preference_platform_supported_language]

PRINT(N'Drop constraint Fk_mobile_business_theme from [ods].[mobile_business]')
ALTER TABLE [ods].[mobile_business] NOCHECK CONSTRAINT [Fk_mobile_business_theme]

PRINT(N'Drop constraint Fk_mobile_business_color from [ods].[mobile_business]')
ALTER TABLE [ods].[mobile_business] NOCHECK CONSTRAINT [Fk_mobile_business_color]

PRINT(N'Drop constraint fk_message_category_role_based_recipient_platform_role from [ods].[message_category_role_based_recipient]')
ALTER TABLE [ods].[message_category_role_based_recipient] NOCHECK CONSTRAINT [fk_message_category_role_based_recipient_platform_role]

PRINT(N'Drop constraint fk_mobilebusiness_to_partyrole_partyrole from [ods].[mobile_business_employee_authorization_group_role]')
ALTER TABLE [ods].[mobile_business_employee_authorization_group_role] NOCHECK CONSTRAINT [fk_mobilebusiness_to_partyrole_partyrole]

PRINT(N'Drop constraint fk_role_operational_function_role from [ods].[role_operational_function]')
ALTER TABLE [ods].[role_operational_function] NOCHECK CONSTRAINT [fk_role_operational_function_role]

PRINT(N'Drop constraint Fk_party_image_platform_participation_type from [ods].[party_image]')
ALTER TABLE [ods].[party_image] NOCHECK CONSTRAINT [Fk_party_image_platform_participation_type]

PRINT(N'Drop constraint Fk_party_platform_objective_priority_platform_participation_type from [ods].[party_platform_objective_priority]')
ALTER TABLE [ods].[party_platform_objective_priority] NOCHECK CONSTRAINT [Fk_party_platform_objective_priority_platform_participation_type]

PRINT(N'Drop constraint Fk_person_as_user_platform_participation_type from [ods].[person_as_user]')
ALTER TABLE [ods].[person_as_user] NOCHECK CONSTRAINT [Fk_person_as_user_platform_participation_type]

PRINT(N'Drop constraint fk_role_operational_function_operational_function from [ods].[role_operational_function]')
ALTER TABLE [ods].[role_operational_function] NOCHECK CONSTRAINT [fk_role_operational_function_operational_function]

PRINT(N'Drop constraint Fk_mobile_business_platform_mobile_business_monthly_volume_bracket from [ods].[mobile_business]')
ALTER TABLE [ods].[mobile_business] NOCHECK CONSTRAINT [Fk_mobile_business_platform_mobile_business_monthly_volume_bracket]

PRINT(N'Drop constraint fk_location_contact_mechanism_contact_mechanism from [ods].[business_location_contact_mechanism]')
ALTER TABLE [ods].[business_location_contact_mechanism] NOCHECK CONSTRAINT [fk_location_contact_mechanism_contact_mechanism]

PRINT(N'Drop constraint fk_device_contact_mechanism from [ods].[device]')
ALTER TABLE [ods].[device] NOCHECK CONSTRAINT [fk_device_contact_mechanism]

PRINT(N'Drop constraint fk_email_address_contact_mechanism from [ods].[email_address]')
ALTER TABLE [ods].[email_address] NOCHECK CONSTRAINT [fk_email_address_contact_mechanism]

PRINT(N'Drop constraint fk_person_adddress from [ods].[person]')
ALTER TABLE [ods].[person] NOCHECK CONSTRAINT [fk_person_adddress]

PRINT(N'Drop constraint fk_restock_alert_contact_mechanism from [ods].[restock_alert]')
ALTER TABLE [ods].[restock_alert] NOCHECK CONSTRAINT [fk_restock_alert_contact_mechanism]

PRINT(N'Drop constraint Fk_business_catgegory_retail_customer_activity_measure_business_cat from [ods].[business_category_retail_customer_activity_measure]')
ALTER TABLE [ods].[business_category_retail_customer_activity_measure] NOCHECK CONSTRAINT [Fk_business_catgegory_retail_customer_activity_measure_business_cat]

PRINT(N'Drop constraint fk_dimension_source_business_category_business_category from [ods].[dimension_source_business_category]')
ALTER TABLE [ods].[dimension_source_business_category] NOCHECK CONSTRAINT [fk_dimension_source_business_category_business_category]

PRINT(N'Add rows to [ods].[business_category]')
SET IDENTITY_INSERT [ods].[business_category] ON
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (1, 'Construction / Home Repair', 'Construction / Home Repair', 0.0000, '23       ', 'Y', 'Y', 'N', '2020-11-04 20:47:46.210')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (2, 'Motor Vehicle and Parts Dealers', 'Motor Vehicle and Parts Dealers', 0.0000, '441      ', 'Y', 'N', 'Y', '2020-11-04 20:47:46.217')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (3, 'Furniture and Home Furnishings Stores', 'Furniture and Home Furnishings Stores', 0.0000, '442      ', 'Y', 'Y', 'Y', '2020-11-04 20:47:46.220')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (4, 'Electronics and Appliance Stores', 'Electronics and Appliance Stores', 0.0000, '443      ', 'Y', 'Y', 'N', '2020-11-04 20:47:46.223')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (5, 'Building Material and Garden Equipment and Supplies Dealers', 'Building Material and Garden Equipment and Supplies Dealers', 0.0000, '444      ', 'Y', 'N', 'N', '2020-11-04 20:47:46.227')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (6, 'Food and Beverage Stores', 'Food and Beverage Stores', 0.0000, '445      ', 'Y', 'N', 'N', '2020-11-04 20:47:46.230')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (7, 'Health and Personal Care Stores', 'Health and Personal Care Stores', 0.0000, '446      ', 'Y', 'N', 'N', '2020-11-04 20:47:46.233')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (8, 'Clothing and Clothing Accessories Stores', 'Clothing and Clothing Accessories Stores', 0.0000, '448      ', 'Y', 'N', 'N', '2020-11-04 20:47:46.237')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (9, 'Sporting Goods, Hobby, Musical Instrument, and Book Stores', 'Sporting Goods, Hobby, Musical Instrument, and Book Stores', 0.0000, '451      ', 'Y', 'N', 'N', '2020-11-04 20:47:46.240')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (10, 'General Merchandise Stores', 'General Merchandise Stores', 0.0000, '452      ', 'Y', 'N', 'N', '2020-11-04 20:47:46.243')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (11, 'Miscellaneous Store Retailers', 'Miscellaneous Store Retailers', 0.0000, '453      ', 'Y', 'N', 'N', '2020-11-04 20:47:46.247')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (12, 'Nonstore Retailers', 'Nonstore Retailers', 0.0000, '454      ', 'Y', 'N', 'N', '2020-11-04 20:47:46.250')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (13, 'Transportation and Warehousing', 'Transportation and Warehousing', 0.0000, '48       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.257')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (14, 'Information', 'Information', 0.0000, '51       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.260')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (15, 'Finance and Insurance', 'Finance and Insurance', 0.0000, '52       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.260')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (16, 'Real Estate and Rental and Leasing', 'Real Estate and Rental and Leasing', 0.0000, '53       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.263')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (17, 'Professional, Scientific, and Technical Services', 'Professional, Scientific, and Technical Services', 0.0000, '54       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.267')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (18, 'Educational Services', 'Educational Services', 0.0000, '61       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.270')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (19, 'Health Care and Social Assistance', 'Health Care and Social Assistance', 0.0000, '62       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.273')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (20, 'Arts, Entertainment, and Recreation', 'Arts, Entertainment, and Recreation', 0.0000, '71       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.277')
INSERT INTO [ods].[business_category] ([business_category_id], [category_name], [text_description], [service_provider_trust_ratio], [naics_code], [ok_for_goods_flag], [ok_for_services_flag], [ok_for_assets_flag], [last_update_timestamp]) VALUES (21, 'Accommodation and Food Services', 'Accommodation and Food Services', 0.0000, '72       ', 'N', 'Y', 'Y', '2020-11-04 20:47:46.280')
SET IDENTITY_INSERT [ods].[business_category] OFF
PRINT(N'Operation applied to 21 rows out of 21')

PRINT(N'Add rows to [ods].[contact_mechanism]')
SET IDENTITY_INSERT [ods].[contact_mechanism] ON
INSERT INTO [ods].[contact_mechanism] ([contact_mechanism_id], [uuid], [last_update_timestamp]) VALUES (1, 'F5778562-3187-4267-87E3-ABB6B63D8097', '2020-11-06 22:41:38.260')
INSERT INTO [ods].[contact_mechanism] ([contact_mechanism_id], [uuid], [last_update_timestamp]) VALUES (2, 'F59CE512-ADD0-4D82-8A27-26DC67C14070', '2020-11-08 19:38:41.333')
SET IDENTITY_INSERT [ods].[contact_mechanism] OFF
PRINT(N'Operation applied to 2 rows out of 2')

PRINT(N'Add rows to [ods].[country]')
SET IDENTITY_INSERT [ods].[country] ON
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (1, 'Afghanistan', 'AF', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (2, 'Albania', 'AL', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (3, 'Algeria', 'DZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (4, 'Andorra', 'AD', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (5, 'Angola', 'AO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (6, 'Antigua', 'AI', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (7, 'Argentina', 'AR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (8, 'Armenia', 'AM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (9, 'Australia', 'AU', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (10, 'Austria', 'AT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (11, 'Azerbaijan', 'AZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (12, 'Bahamas', 'BS', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (13, 'Bahrain', 'BH', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (14, 'Bangladesh', 'BD', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (15, 'Barbados', 'BB', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (16, 'Belarus', 'BV', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (17, 'Belgium', 'BE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (18, 'Belize', 'BZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (19, 'Benin', 'BJ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (20, 'Bhutan', 'BT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (21, 'Bolivia', 'BO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (22, 'Bosnia', 'BA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (23, 'Botswana', 'BW', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (24, 'Brazil', 'BR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (25, 'Brunei', 'BN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (26, 'Bulgaria', 'BG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (27, 'Burkina Faso', 'BF', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (28, 'Burundi', 'BI', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (29, 'Côte d.Ivoire', 'CI', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (30, 'Cabo Verde', 'CV', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (31, 'Cambodia', 'KH', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (32, 'Cameroon', 'CM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (33, 'Canada', 'CA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (34, 'Central African Republic', 'CF', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (35, 'Chad', 'TD', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (36, 'Chile', 'CL', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (37, 'China', 'CN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (38, 'Colombia', 'CO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (39, 'Comoros', 'KM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (40, 'Congo (Congo-Brazzaville)', 'CG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (41, 'Costa Rica', 'CR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (42, 'Croatia', 'HR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (43, 'Cuba', 'CU', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (44, 'Cyprus', 'CY', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (45, 'Czechia', 'CZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (46, 'Czech Republic', 'CZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (47, 'Democratic Republic of the Congo', 'CD', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (48, 'Denmark', 'DK', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (49, 'Djibouti', 'DJ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (50, 'Dominica', 'DM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (51, 'Dominican Republic', 'DO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (52, 'Ecuador', 'EC', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (53, 'Egypt', 'EG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (54, 'El Salvador', 'SV', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (55, 'Equatorial Guinea', 'GQ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (56, 'Eritrea', 'ER', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (57, 'Estonia', 'EE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (58, 'Eswatini', 'SZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (59, 'fmr. "Swaziland"', 'SZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (60, 'Ethiopia', 'ET', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (61, 'Fiji', 'FJ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (62, 'Finland', 'FI', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (63, 'France', 'FR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (64, 'Gabon', 'GA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (65, 'Gambia', 'GM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (66, 'Georgia', 'GE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (67, 'Germany', 'GE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (68, 'Ghana', 'GH', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (69, 'Greece', 'GR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (70, 'Grenada', 'GD', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (71, 'Guatemala', 'GT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (72, 'Guinea', 'GN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (73, 'Guinea-Bissau', 'GW', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (74, 'Guyana', 'GY', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (75, 'Haiti', 'HT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (76, 'Holy See', 'VA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (77, 'Honduras', 'HN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (78, 'Hungary', 'HU', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (79, 'Iceland', 'IS', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (80, 'India', 'IN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (81, 'Indonesia', 'ID', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (82, 'Iran', 'IR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (83, 'Iraq', 'IQ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (84, 'Ireland', 'IE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (85, 'Israel', 'IL', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (86, 'Italy', 'IT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (87, 'Jamaica', 'JM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (88, 'Japan', 'JP', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (89, 'Jordan', 'JO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (90, 'Kazakhstan', 'KG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (91, 'Kenya', 'KE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (92, 'Kiribati', 'KI', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (93, 'Kuwait', 'KW', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (94, 'Kyrgyzstan', 'KZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (95, 'Laos', 'LA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (96, 'Latvia', 'LV', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (97, 'Lebanon', 'LB', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (98, 'Lesotho', 'LS', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (99, 'Liberia', 'LR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (100, 'Libya', 'LY', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (101, 'Liechtenstein', 'LI', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (102, 'Lithuania', 'LT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (103, 'Luxembourg', 'LU', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (104, 'Madagascar', 'MG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (105, 'Malawi', 'MW', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (106, 'Malaysia', 'MY', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (107, 'Maldives', 'MV', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (108, 'Mali', 'ML', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (109, 'Malta', 'MT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (110, 'Marshall Islands', 'MH', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (111, 'Mauritania', 'MR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (112, 'Mauritius', 'MU', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (113, 'Mexico', 'MX', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (114, 'Micronesia', 'FM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (115, 'Moldova', 'MD', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (116, 'Monaco', 'MC', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (117, 'Mongolia', 'MN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (118, 'Montenegro', 'ME', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (119, 'Morocco', 'MA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (120, 'Mozambique', 'MZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (121, 'Myanmar (formerly Burma)', 'MM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (122, 'Namibia', 'NA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (123, 'Nauru', 'NR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (124, 'Nepal', 'NP', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (125, 'Netherlands', 'NL', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (126, 'New Zealand', 'NZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (127, 'Nicaragua', 'NI', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (128, 'Niger', 'NE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (129, 'Nigeria', 'NG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (130, 'North Korea', 'KP', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (131, 'North Macedonia', 'MK', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (132, 'Norway', 'NO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (133, 'Oman', 'OM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (134, 'Pakistan', 'PK', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (135, 'Palau', 'PW', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (136, 'Palestine State', 'PS', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (137, 'Panama', 'PA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (138, 'Papua New Guinea', 'PG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (139, 'Paraguay', 'PY', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (140, 'Peru', 'PE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (141, 'Philippines', 'PH', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (142, 'Poland', 'PL', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (143, 'Portugal', 'PT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (144, 'Qatar', 'QA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (145, 'Romania', 'RO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (146, 'Russia', 'RU', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (147, 'Rwanda', 'RW', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (148, 'Saint Kitts', 'KN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (149, 'Saint Lucia', 'LC', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (150, 'Saint Vincent and the Grenadines', 'VC', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (151, 'Samoa', 'WS', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (152, 'San Marino', 'SM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (153, 'Sao Tome and Principe', 'ST', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (154, 'Saudi Arabia', 'SA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (155, 'Senegal', 'SN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (156, 'Serbia', 'RS', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (157, 'Seychelles', 'SC', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (158, 'Sierra Leone', 'SL', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (159, 'Singapore', 'SG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (160, 'Slovakia', 'SK', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (161, 'Slovenia', 'SI', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (162, 'Solomon Islands', 'SB', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (163, 'Somalia', 'SO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (164, 'South Africa', 'ZA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (165, 'South Korea', 'KR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (166, 'South Sudan', 'SS', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (167, 'Spain', 'ES', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (168, 'Sri Lanka', 'LK', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (169, 'Sudan', 'SD', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (170, 'Suriname', 'SR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (171, 'Sweden', 'SE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (172, 'Switzerland', 'CH', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (173, 'Syria', 'SY', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (174, 'Tajikistan', 'TJ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (175, 'Tanzania', 'TZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (176, 'Thailand', 'TH', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (177, 'Timor-Leste', 'TL', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (178, 'Togo', 'TG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (179, 'Tonga', 'TO', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (180, 'Trinidad and Tobago', 'TT', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (181, 'Tunisia', 'TN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (182, 'Turkey', 'TR', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (183, 'Turkmenistan', 'TM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (184, 'Tuvalu', 'TV', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (185, 'Uganda', 'UG', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (186, 'Ukraine', 'UA', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (187, 'United Arab Emirates', 'AE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (188, 'United Kingdom', 'UK', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (189, 'United States of America', 'US', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (190, 'Uruguay', 'UY', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (191, 'Uzbekistan', 'UZ', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (192, 'Vanuatu', 'VU', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (193, 'Venezuela', 'VE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (194, 'Vietnam', 'VN', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (195, 'Yemen', 'YE', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (196, 'Zambia', 'ZM', '2020-11-04 20:47:46.550')
INSERT INTO [ods].[country] ([country_id], [country_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (197, 'Zimbabwe', 'ZW', '2020-11-04 20:47:46.550')
SET IDENTITY_INSERT [ods].[country] OFF
PRINT(N'Operation applied to 197 rows out of 197')

PRINT(N'Add rows to [ods].[platform_asset_class]')
SET IDENTITY_INSERT [ods].[platform_asset_class] ON
INSERT INTO [ods].[platform_asset_class] ([platform_asset_class_id], [class_name], [last_update_timestamp]) VALUES (1, 'Properties', '2020-11-04 20:47:46.287')
INSERT INTO [ods].[platform_asset_class] ([platform_asset_class_id], [class_name], [last_update_timestamp]) VALUES (2, 'Equipment', '2020-11-04 20:47:46.290')
INSERT INTO [ods].[platform_asset_class] ([platform_asset_class_id], [class_name], [last_update_timestamp]) VALUES (3, 'Inventory', '2020-11-04 20:47:46.293')
SET IDENTITY_INSERT [ods].[platform_asset_class] OFF
PRINT(N'Operation applied to 3 rows out of 3')

PRINT(N'Add rows to [ods].[platform_mobile_business_monthly_volume_bracket]')
SET IDENTITY_INSERT [ods].[platform_mobile_business_monthly_volume_bracket] ON
INSERT INTO [ods].[platform_mobile_business_monthly_volume_bracket] ([platform_mobile_business_monthly_volume_bracket_id], [minimum_volume_threshold], [maximum_volume_threshold], [last_update_timestamp]) VALUES (1, 0.00, 10000.00, '2020-11-04 20:47:46.513')
INSERT INTO [ods].[platform_mobile_business_monthly_volume_bracket] ([platform_mobile_business_monthly_volume_bracket_id], [minimum_volume_threshold], [maximum_volume_threshold], [last_update_timestamp]) VALUES (2, 10000.00, 25000.00, '2020-11-04 20:47:46.517')
INSERT INTO [ods].[platform_mobile_business_monthly_volume_bracket] ([platform_mobile_business_monthly_volume_bracket_id], [minimum_volume_threshold], [maximum_volume_threshold], [last_update_timestamp]) VALUES (3, 25000.00, 50000.00, '2020-11-04 20:47:46.520')
INSERT INTO [ods].[platform_mobile_business_monthly_volume_bracket] ([platform_mobile_business_monthly_volume_bracket_id], [minimum_volume_threshold], [maximum_volume_threshold], [last_update_timestamp]) VALUES (4, 50000.00, 100000.00, '2020-11-04 20:47:46.523')
INSERT INTO [ods].[platform_mobile_business_monthly_volume_bracket] ([platform_mobile_business_monthly_volume_bracket_id], [minimum_volume_threshold], [maximum_volume_threshold], [last_update_timestamp]) VALUES (5, 100000.00, 99999999.00, '2020-11-04 20:47:46.527')
SET IDENTITY_INSERT [ods].[platform_mobile_business_monthly_volume_bracket] OFF
PRINT(N'Operation applied to 5 rows out of 5')

PRINT(N'Add rows to [ods].[platform_operational_function]')
SET IDENTITY_INSERT [ods].[platform_operational_function] ON
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (1, 'Maintain Offers / Docial Media Hash Tags and keywords', '2020-11-04', '2020-11-04 20:47:46.423')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (2, 'Maintain Invoices and Accounts Receivable', '2020-11-04', '2020-11-04 20:47:46.427')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (3, 'Maintain Inventory Levels', '2020-11-04', '2020-11-04 20:47:46.430')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (4, 'Review Financial Reports', '2020-11-04', '2020-11-04 20:47:46.433')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (5, 'Add Location', '2020-11-04', '2020-11-04 20:47:46.437')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (6, 'Set enterprise Hours of Operation', '2020-11-04', '2020-11-04 20:47:46.440')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (7, 'Set Location Hours of Operation', '2020-11-04', '2020-11-04 20:47:46.443')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (8, 'Maintain econic roles, functions and role function authorizations', '2020-11-04', '2020-11-04 20:47:46.447')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (9, 'Activate Mobile Business', '2020-11-04', '2020-11-04 20:47:46.450')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (10, 'Create a Mobile Business', '2020-11-04', '2020-11-04 20:47:46.453')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (11, 'Load Mobile Business Prospective Retail Customers', '2020-11-04', '2020-11-04 20:47:46.457')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (12, 'Load Mobile Business "Prospective" Employees', '2020-11-04', '2020-11-04 20:47:46.460')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (13, 'Maintain Employee Records', '2020-11-04', '2020-11-04 20:47:46.463')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (14, 'De-platform Mobile Business', '2020-11-04', '2020-11-04 20:47:46.467')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (15, 'De-platform Retail Customer', '2020-11-04', '2020-11-04 20:47:46.470')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (16, 'Maintain Product Catalog', '2020-11-04', '2020-11-04 20:47:46.470')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (17, 'Configure Enterprise Service Delivery', '2020-11-04', '2020-11-04 20:47:46.473')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (18, 'Maintain Employee to Service Qualifications', '2020-11-04', '2020-11-04 20:47:46.477')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (19, 'Set Employee Work Schedule', '2020-11-04', '2020-11-04 20:47:46.480')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (20, 'Set Employee Service Schedule', '2020-11-04', '2020-11-04 20:47:46.483')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (21, 'Configure Employee Evaluation Criteria', '2020-11-04', '2020-11-04 20:47:46.487')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (22, 'Create Auctions', '2020-11-04', '2020-11-04 20:47:46.490')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (23, 'Assign Products to Sample, Showcase and Catalog', '2020-11-04', '2020-11-04 20:47:46.493')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (24, 'Pick Charities and Elect Match %s', '2020-11-04', '2020-11-04 20:47:46.497')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (25, 'Maintain acepted set of payment and shipment methods', '2020-11-04', '2020-11-04 20:47:46.500')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (26, 'Ship an Order', '2020-11-04', '2020-11-04 20:47:46.503')
INSERT INTO [ods].[platform_operational_function] ([platform_operational_function_id], [function_name], [create_date], [last_update_timestamp]) VALUES (27, 'Check Out a Retail Customer', '2020-11-04', '2020-11-04 20:47:46.507')
SET IDENTITY_INSERT [ods].[platform_operational_function] OFF
PRINT(N'Operation applied to 27 rows out of 27')

PRINT(N'Add rows to [ods].[platform_participant_type]')
SET IDENTITY_INSERT [ods].[platform_participant_type] ON
INSERT INTO [ods].[platform_participant_type] ([platform_participant_type_id], [participant_type_indicator], [text_description], [last_update_timestamp]) VALUES (1, 'OWN', 'Mobile Business Owner', '2020-11-04 20:47:46.300')
INSERT INTO [ods].[platform_participant_type] ([platform_participant_type_id], [participant_type_indicator], [text_description], [last_update_timestamp]) VALUES (2, 'MBE', 'Mobile Business Employee', '2020-11-04 20:47:46.300')
INSERT INTO [ods].[platform_participant_type] ([platform_participant_type_id], [participant_type_indicator], [text_description], [last_update_timestamp]) VALUES (3, 'RC ', 'Retail Cusotmer', '2020-11-04 20:47:46.300')
INSERT INTO [ods].[platform_participant_type] ([platform_participant_type_id], [participant_type_indicator], [text_description], [last_update_timestamp]) VALUES (4, 'PE ', 'Platform Employee', '2020-11-04 20:47:46.300')
INSERT INTO [ods].[platform_participant_type] ([platform_participant_type_id], [participant_type_indicator], [text_description], [last_update_timestamp]) VALUES (5, 'MBA', 'Mobile Business Aggregator', '2020-11-04 20:47:46.300')
SET IDENTITY_INSERT [ods].[platform_participant_type] OFF
PRINT(N'Operation applied to 5 rows out of 5')

PRINT(N'Add row to [ods].[platform_recruitement_message]')
SET IDENTITY_INSERT [ods].[platform_recruitement_message] ON
INSERT INTO [ods].[platform_recruitement_message] ([platform_recruitement_message_id], [mobile_business_employee_recruitement_message], [retail_customer_recruitement_message], [last_update_timestamp]) VALUES (1, 'To all my best customers and VIPs, this is an advnace invitation to our new all that provides you special deals and rewards your loyalty.', 'Check out our new Revyvv mobile business. THis will help us sell our best products and services to our best customers.', '2020-11-04 20:47:46.630')
SET IDENTITY_INSERT [ods].[platform_recruitement_message] OFF

PRINT(N'Add rows to [ods].[platform_role]')
SET IDENTITY_INSERT [ods].[platform_role] ON
INSERT INTO [ods].[platform_role] ([platform_role_id], [role_description], [create_date], [last_update_timestamp]) VALUES (1, 'Mobile Business Owner', '2020-11-04', '2020-11-04 20:47:46.397')
INSERT INTO [ods].[platform_role] ([platform_role_id], [role_description], [create_date], [last_update_timestamp]) VALUES (2, 'Mobile Business Employee', '2020-11-04', '2020-11-04 20:47:46.400')
INSERT INTO [ods].[platform_role] ([platform_role_id], [role_description], [create_date], [last_update_timestamp]) VALUES (3, 'Location Manager', '2020-11-04', '2020-11-04 20:47:46.403')
INSERT INTO [ods].[platform_role] ([platform_role_id], [role_description], [create_date], [last_update_timestamp]) VALUES (4, 'Retail Customer', '2020-11-04', '2020-11-04 20:47:46.407')
INSERT INTO [ods].[platform_role] ([platform_role_id], [role_description], [create_date], [last_update_timestamp]) VALUES (5, 'Econic System Administrator', '2020-11-04', '2020-11-04 20:47:46.410')
INSERT INTO [ods].[platform_role] ([platform_role_id], [role_description], [create_date], [last_update_timestamp]) VALUES (6, 'Econic Onboarding Specialist', '2020-11-04', '2020-11-04 20:47:46.413')
INSERT INTO [ods].[platform_role] ([platform_role_id], [role_description], [create_date], [last_update_timestamp]) VALUES (7, 'Mobile Business Employee Location Manager', '2020-11-04', '2020-11-04 20:47:46.417')
SET IDENTITY_INSERT [ods].[platform_role] OFF
PRINT(N'Operation applied to 7 rows out of 7')

PRINT(N'Add rows to [ods].[platform_screens_main_color]')
SET IDENTITY_INSERT [ods].[platform_screens_main_color] ON
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (1, NULL, '#C72129', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (2, NULL, '#FF8611', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (3, NULL, '#32922C', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (4, NULL, '#11A18E', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (5, NULL, '#000059', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (6, NULL, '#0070F4', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (7, NULL, '#CC4A82', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (8, NULL, '#754313', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (9, NULL, '#354134', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (10, NULL, '#7323A8', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (11, NULL, '#6F6F6F', '2020-11-06 19:54:29.730')
INSERT INTO [ods].[platform_screens_main_color] ([platform_screens_main_color_id], [color_image], [hexidecimal_code], [last_update_timestamp]) VALUES (12, NULL, '#C9A015', '2020-11-06 19:54:29.730')
SET IDENTITY_INSERT [ods].[platform_screens_main_color] OFF
PRINT(N'Operation applied to 12 rows out of 12')

PRINT(N'Add rows to [ods].[platform_standard_service_duration]')
SET IDENTITY_INSERT [ods].[platform_standard_service_duration] ON
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (1, 15, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (2, 30, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (3, 45, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (4, 60, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (5, 75, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (6, 90, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (7, 120, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (8, 150, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (9, 180, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (10, 240, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (11, 360, '2020-11-04 20:47:46.643')
INSERT INTO [ods].[platform_standard_service_duration] ([platform_standard_service_duration_id], [expected_duration], [last_update_timestamp]) VALUES (12, 480, '2020-11-04 20:47:46.643')
SET IDENTITY_INSERT [ods].[platform_standard_service_duration] OFF
PRINT(N'Operation applied to 12 rows out of 12')

PRINT(N'Add rows to [ods].[platform_store_theme]')
SET IDENTITY_INSERT [ods].[platform_store_theme] ON
INSERT INTO [ods].[platform_store_theme] ([platform_store_theme_id], [text_description], [theme_image], [last_update_timestamp]) VALUES (1, 'Classic', NULL, '2020-11-06 19:42:35.103')
INSERT INTO [ods].[platform_store_theme] ([platform_store_theme_id], [text_description], [theme_image], [last_update_timestamp]) VALUES (2, 'Modern', NULL, '2020-11-06 19:42:35.103')
INSERT INTO [ods].[platform_store_theme] ([platform_store_theme_id], [text_description], [theme_image], [last_update_timestamp]) VALUES (3, 'Friendly', NULL, '2020-11-06 19:42:35.103')
SET IDENTITY_INSERT [ods].[platform_store_theme] OFF
PRINT(N'Operation applied to 3 rows out of 3')

PRINT(N'Add rows to [ods].[platform_supported_language]')
SET IDENTITY_INSERT [ods].[platform_supported_language] ON
INSERT INTO [ods].[platform_supported_language] ([platform_supported_language_id], [language_code], [text_name], [last_update_timestamp]) VALUES (1, 'EGL ', 'English', '2020-11-04 20:47:46.617')
INSERT INTO [ods].[platform_supported_language] ([platform_supported_language_id], [language_code], [text_name], [last_update_timestamp]) VALUES (2, 'ESP ', 'Spanish', '2020-11-04 20:47:46.617')
SET IDENTITY_INSERT [ods].[platform_supported_language] OFF
PRINT(N'Operation applied to 2 rows out of 2')

PRINT(N'Add rows to [ods].[service_area_bracket]')
SET IDENTITY_INSERT [ods].[service_area_bracket] ON
INSERT INTO [ods].[service_area_bracket] ([service_area_bracket_id], [bracket_distance_in_miles], [last_update_timestamp]) VALUES (1, '1', '2020-11-04 20:47:46.580')
INSERT INTO [ods].[service_area_bracket] ([service_area_bracket_id], [bracket_distance_in_miles], [last_update_timestamp]) VALUES (2, '3', '2020-11-04 20:47:46.580')
INSERT INTO [ods].[service_area_bracket] ([service_area_bracket_id], [bracket_distance_in_miles], [last_update_timestamp]) VALUES (3, '5', '2020-11-04 20:47:46.580')
INSERT INTO [ods].[service_area_bracket] ([service_area_bracket_id], [bracket_distance_in_miles], [last_update_timestamp]) VALUES (4, 'Unlimited', '2020-11-04 20:47:46.580')
SET IDENTITY_INSERT [ods].[service_area_bracket] OFF
PRINT(N'Operation applied to 4 rows out of 4')

PRINT(N'Add rows to [ods].[tax_item_type]')
SET IDENTITY_INSERT [ods].[tax_item_type] ON
INSERT INTO [ods].[tax_item_type] ([tax_item_type_id], [tax_type_name], [last_update_timestamp]) VALUES (2, 'Clothing', '2020-11-04 20:47:46.200')
INSERT INTO [ods].[tax_item_type] ([tax_item_type_id], [tax_type_name], [last_update_timestamp]) VALUES (3, 'Food', '2020-11-04 20:47:46.200')
INSERT INTO [ods].[tax_item_type] ([tax_item_type_id], [tax_type_name], [last_update_timestamp]) VALUES (4, 'Candy', '2020-11-04 20:47:46.200')
INSERT INTO [ods].[tax_item_type] ([tax_item_type_id], [tax_type_name], [last_update_timestamp]) VALUES (7, 'Supplements', '2020-11-04 20:47:46.200')
INSERT INTO [ods].[tax_item_type] ([tax_item_type_id], [tax_type_name], [last_update_timestamp]) VALUES (8, 'Installation Services', '2020-11-04 20:47:46.200')
INSERT INTO [ods].[tax_item_type] ([tax_item_type_id], [tax_type_name], [last_update_timestamp]) VALUES (9, 'Exempt Service', '2020-11-04 20:47:46.200')
INSERT INTO [ods].[tax_item_type] ([tax_item_type_id], [tax_type_name], [last_update_timestamp]) VALUES (10, 'Meals', '2020-11-04 20:47:46.200')
INSERT INTO [ods].[tax_item_type] ([tax_item_type_id], [tax_type_name], [last_update_timestamp]) VALUES (11, 'Nontax', '2020-11-04 20:47:46.200')
SET IDENTITY_INSERT [ods].[tax_item_type] OFF
PRINT(N'Operation applied to 8 rows out of 8')

PRINT(N'Add rows to [ods].[transaction_size_bracket]')
SET IDENTITY_INSERT [ods].[transaction_size_bracket] ON
INSERT INTO [ods].[transaction_size_bracket] ([transaction_size_bracket_id], [transaction_size_lower_bound], [transaction_size_upper_bound], [last_update_timestamp]) VALUES (2, 0.00, 5.00, '2020-11-06 20:03:33.653')
INSERT INTO [ods].[transaction_size_bracket] ([transaction_size_bracket_id], [transaction_size_lower_bound], [transaction_size_upper_bound], [last_update_timestamp]) VALUES (3, 5.00, 15.00, '2020-11-06 20:03:33.653')
INSERT INTO [ods].[transaction_size_bracket] ([transaction_size_bracket_id], [transaction_size_lower_bound], [transaction_size_upper_bound], [last_update_timestamp]) VALUES (4, 15.00, 30.00, '2020-11-06 20:03:33.653')
INSERT INTO [ods].[transaction_size_bracket] ([transaction_size_bracket_id], [transaction_size_lower_bound], [transaction_size_upper_bound], [last_update_timestamp]) VALUES (5, 30.00, 90.00, '2020-11-06 20:03:33.653')
INSERT INTO [ods].[transaction_size_bracket] ([transaction_size_bracket_id], [transaction_size_lower_bound], [transaction_size_upper_bound], [last_update_timestamp]) VALUES (6, 90.00, 250.00, '2020-11-06 20:03:33.653')
INSERT INTO [ods].[transaction_size_bracket] ([transaction_size_bracket_id], [transaction_size_lower_bound], [transaction_size_upper_bound], [last_update_timestamp]) VALUES (7, 250.00, 99999999.99, '2020-11-06 20:03:33.653')
SET IDENTITY_INSERT [ods].[transaction_size_bracket] OFF
PRINT(N'Operation applied to 6 rows out of 6')

PRINT(N'Add rows to [ods].[transactons_per_month_bracket]')
SET IDENTITY_INSERT [ods].[transactons_per_month_bracket] ON
INSERT INTO [ods].[transactons_per_month_bracket] ([transactons_per_month_bracket_id], [number_of_transactions_lower_bound], [number_of_transactions_upper_bound], [last_update_time_stamp]) VALUES (1, 0, 20, '2020-11-04 20:47:46.587')
INSERT INTO [ods].[transactons_per_month_bracket] ([transactons_per_month_bracket_id], [number_of_transactions_lower_bound], [number_of_transactions_upper_bound], [last_update_time_stamp]) VALUES (2, 20, 50, '2020-11-04 20:47:46.587')
INSERT INTO [ods].[transactons_per_month_bracket] ([transactons_per_month_bracket_id], [number_of_transactions_lower_bound], [number_of_transactions_upper_bound], [last_update_time_stamp]) VALUES (3, 50, 100, '2020-11-04 20:47:46.587')
INSERT INTO [ods].[transactons_per_month_bracket] ([transactons_per_month_bracket_id], [number_of_transactions_lower_bound], [number_of_transactions_upper_bound], [last_update_time_stamp]) VALUES (4, 100, 500, '2020-11-04 20:47:46.587')
INSERT INTO [ods].[transactons_per_month_bracket] ([transactons_per_month_bracket_id], [number_of_transactions_lower_bound], [number_of_transactions_upper_bound], [last_update_time_stamp]) VALUES (5, 500, 1000, '2020-11-04 20:47:46.587')
INSERT INTO [ods].[transactons_per_month_bracket] ([transactons_per_month_bracket_id], [number_of_transactions_lower_bound], [number_of_transactions_upper_bound], [last_update_time_stamp]) VALUES (6, 1000, 5000, '2020-11-04 20:47:46.587')
INSERT INTO [ods].[transactons_per_month_bracket] ([transactons_per_month_bracket_id], [number_of_transactions_lower_bound], [number_of_transactions_upper_bound], [last_update_time_stamp]) VALUES (7, 5000, 99999, '2020-11-04 20:47:46.587')
SET IDENTITY_INSERT [ods].[transactons_per_month_bracket] OFF
PRINT(N'Operation applied to 7 rows out of 7')

PRINT(N'Add rows to [ods].[trusted_trade_type]')
SET IDENTITY_INSERT [ods].[trusted_trade_type] ON
INSERT INTO [ods].[trusted_trade_type] ([trusted_trade_type_id], [text_name], [text_description], [last_update_timestamp]) VALUES (1, 'Clearance', 'Lowest prices', '2020-11-04 20:47:46.633')
INSERT INTO [ods].[trusted_trade_type] ([trusted_trade_type_id], [text_name], [text_description], [last_update_timestamp]) VALUES (2, 'Good Deal', 'A deal but not the lowest price', '2020-11-04 20:47:46.633')
INSERT INTO [ods].[trusted_trade_type] ([trusted_trade_type_id], [text_name], [text_description], [last_update_timestamp]) VALUES (3, 'Points', 'Chance for more points', '2020-11-04 20:47:46.633')
INSERT INTO [ods].[trusted_trade_type] ([trusted_trade_type_id], [text_name], [text_description], [last_update_timestamp]) VALUES (4, 'Black Friday', 'Multiple items on sale', '2020-11-04 20:47:46.633')
SET IDENTITY_INSERT [ods].[trusted_trade_type] OFF
PRINT(N'Operation applied to 4 rows out of 4')

PRINT(N'Add rows to [ods].[virtue]')
SET IDENTITY_INSERT [ods].[virtue] ON
INSERT INTO [ods].[virtue] ([virtue_id], [text_name], [platform_employee_ranking], [platform_employee_weight], [platform_mobile_business_ranking], [platform_mobile_business_weight], [platform_retail_customer_ranking], [platform_retail_customer_weight], [last_update_timestamp]) VALUES (1, 'Credibility', NULL, NULL, NULL, NULL, NULL, NULL, '2020-11-04 20:47:46.590')
INSERT INTO [ods].[virtue] ([virtue_id], [text_name], [platform_employee_ranking], [platform_employee_weight], [platform_mobile_business_ranking], [platform_mobile_business_weight], [platform_retail_customer_ranking], [platform_retail_customer_weight], [last_update_timestamp]) VALUES (2, 'Trust', NULL, NULL, NULL, NULL, NULL, NULL, '2020-11-04 20:47:46.590')
INSERT INTO [ods].[virtue] ([virtue_id], [text_name], [platform_employee_ranking], [platform_employee_weight], [platform_mobile_business_ranking], [platform_mobile_business_weight], [platform_retail_customer_ranking], [platform_retail_customer_weight], [last_update_timestamp]) VALUES (3, 'Risk', NULL, NULL, NULL, NULL, NULL, NULL, '2020-11-04 20:47:46.590')
INSERT INTO [ods].[virtue] ([virtue_id], [text_name], [platform_employee_ranking], [platform_employee_weight], [platform_mobile_business_ranking], [platform_mobile_business_weight], [platform_retail_customer_ranking], [platform_retail_customer_weight], [last_update_timestamp]) VALUES (4, 'Loaylaty', NULL, NULL, NULL, NULL, NULL, NULL, '2020-11-04 20:47:46.590')
INSERT INTO [ods].[virtue] ([virtue_id], [text_name], [platform_employee_ranking], [platform_employee_weight], [platform_mobile_business_ranking], [platform_mobile_business_weight], [platform_retail_customer_ranking], [platform_retail_customer_weight], [last_update_timestamp]) VALUES (5, 'Profit', NULL, NULL, NULL, NULL, NULL, NULL, '2020-11-04 20:47:46.590')
SET IDENTITY_INSERT [ods].[virtue] OFF
PRINT(N'Operation applied to 5 rows out of 5')

PRINT(N'Add row to [ods].[party_contact_mechanism]')
SET IDENTITY_INSERT [ods].[party_contact_mechanism] ON
INSERT INTO [ods].[party_contact_mechanism] ([party_contact_mechanism_id], [party_fk], [contact_mechanism_fk], [contact_role_fk], [last_update_timestamp]) VALUES (1, 18, 2, NULL, '2020-11-08 19:38:41.337')
SET IDENTITY_INSERT [ods].[party_contact_mechanism] OFF

PRINT(N'Add rows to [ods].[platform_objective]')
SET IDENTITY_INSERT [ods].[platform_objective] ON
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (1, 1, 'DCC', 'Direct Customer Connect', '2020-11-04 20:47:46.310')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (2, 1, 'IMP', 'Increase My Profit', '2020-11-04 20:47:46.317')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (3, 1, 'ICL', 'Increase Customer Loyalty', '2020-11-04 20:47:46.320')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (4, 1, 'IBC', 'Indentify Best Customers', '2020-11-04 20:47:46.327')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (5, 1, 'LTC', 'Lower My Transaction Costs', '2020-11-04 20:47:46.333')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (6, 2, 'IME', 'Increase My Earnings', '2020-11-04 20:47:46.340')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (7, 2, 'FMC', 'Find My Best Customers', '2020-11-04 20:47:46.343')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (8, 2, 'CTC', 'Direct Connections to My Customers', '2020-11-04 20:47:46.350')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (9, 2, 'ERB', 'Earn Employer Rewards & Benefits', '2020-11-04 20:47:46.357')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (10, 2, 'SM ', 'Sell More', '2020-11-04 20:47:46.363')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (11, 3, 'ELR', 'Earn Loyalty Rewards', '2020-11-04 20:47:46.370')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (12, 3, 'GBD', 'Get the deals', '2020-11-04 20:47:46.373')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (13, 3, 'GDC', 'Get directly connected with my sellers', '2020-11-04 20:47:46.380')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (14, 3, 'BPP', 'Find better plyment plans', '2020-11-04 20:47:46.387')
INSERT INTO [ods].[platform_objective] ([platform_objective_id], [platform_participant_type_fk], [business_objective_code], [business_objective_description], [last_update_timestamp]) VALUES (15, 3, 'GPO', 'Get personalized offers', '2020-11-04 20:47:46.393')
SET IDENTITY_INSERT [ods].[platform_objective] OFF
PRINT(N'Operation applied to 15 rows out of 15')

PRINT(N'Add rows to [ods].[platform_virtue_grade]')
SET IDENTITY_INSERT [ods].[platform_virtue_grade] ON
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (1, 1, 'Bronze', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (2, 2, 'Bronze', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (3, 3, 'Bronze', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (4, 4, 'Bronze', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (5, 5, 'Bronze', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (6, 1, 'Silver', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (7, 2, 'Silver', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (8, 3, 'Silver', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (9, 4, 'Silver', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (10, 5, 'Silver', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (11, 1, 'Gold', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (12, 2, 'Gold', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (13, 3, 'Gold', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (14, 4, 'Gold', '2020-11-04 20:47:46.607')
INSERT INTO [ods].[platform_virtue_grade] ([platform_virtue_grade_id], [virtue_fk], [text_name], [last_update_timestamp]) VALUES (15, 5, 'Gold', '2020-11-04 20:47:46.607')
SET IDENTITY_INSERT [ods].[platform_virtue_grade] OFF
PRINT(N'Operation applied to 15 rows out of 15')

PRINT(N'Add row to [ods].[post_office_address]')
INSERT INTO [ods].[post_office_address] ([post_office_address_id], [address_type], [addrress_source], [address_line_1], [address_line_2], [address_line_3], [city], [state_postal_code], [zip_code], [country_cd], [latitude], [longitude], [verified_dt], [last_update_timestamp]) VALUES (1, 'P', NULL, '4700 N Josey Lane', 'Apt. 3922', NULL, 'Carrollton', 'TX', '75010    ', NULL, NULL, NULL, NULL, '2020-11-06 22:46:26.840')

PRINT(N'Add rows to [ods].[state_or_province]')
SET IDENTITY_INSERT [ods].[state_or_province] ON
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (1, 189, 'Alabama', 'AL', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (2, 189, 'Nebraska', 'NE', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (3, 189, 'Alaska', 'AK', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (4, 189, 'Nevada', 'NV', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (5, 189, 'Arizona', 'AZ', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (6, 189, 'New Hampshire', 'NH', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (7, 189, 'Arkansas', 'AR', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (8, 189, 'New Jersey', 'NJ', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (9, 189, 'California', 'CA', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (10, 189, 'New Mexico', 'NM', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (11, 189, 'Colorado', 'CO', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (12, 189, 'New York', 'NY', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (13, 189, 'Connecticut', 'CT', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (14, 189, 'North Carolina', 'NC', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (15, 189, 'Delaware', 'DE', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (16, 189, 'North Dakota', 'ND', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (17, 189, 'District of Columbia', 'DC', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (18, 189, 'Ohio', 'OH', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (19, 189, 'Florida', 'FL', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (20, 189, 'Oklahoma', 'OK', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (21, 189, 'Georgia', 'GA', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (22, 189, 'Oregon', 'OR', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (23, 189, 'Hawaii', 'HI', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (24, 189, 'Pennsylvania', 'PA', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (25, 189, 'Idaho', 'ID', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (26, 189, 'Puerto Rico', 'PR', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (27, 189, 'Illinois', 'IL', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (28, 189, 'Rhode Island', 'RI', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (29, 189, 'Indiana', 'IN', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (30, 189, 'South Carolina', 'SC', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (31, 189, 'Iowa', 'IA', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (32, 189, 'South Dakota', 'SD', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (33, 189, 'Kansas', 'KS', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (34, 189, 'Tennessee', 'TN', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (35, 189, 'Kentucky', 'KY', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (36, 189, 'Texas', 'TX', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (37, 189, 'Louisiana', 'LA', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (38, 189, 'Utah', 'UT', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (39, 189, 'Maine', 'ME', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (40, 189, 'Vermont', 'VT', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (41, 189, 'Maryland', 'MD', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (42, 189, 'Virginia', 'VA', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (43, 189, 'Massachusetts', 'MA', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (44, 189, 'Virgin Islands', 'VI', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (45, 189, 'Michigan', 'MI', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (46, 189, 'Washington', 'WA', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (47, 189, 'Minnesota', 'MN', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (48, 189, 'West Virginia', 'WV', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (49, 189, 'Mississippi', 'MS', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (50, 189, 'Wisconsin', 'WI', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (51, 189, 'Missouri', 'MO', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (52, 189, 'Wyoming', 'WY', '2020-11-04 20:47:46.570')
INSERT INTO [ods].[state_or_province] ([state_or_province_id], [country_fk], [state_or_province_name], [postal_abbreviation], [last_update_time_stamp]) VALUES (53, 189, 'Montana', 'MT', '2020-11-04 20:47:46.570')
SET IDENTITY_INSERT [ods].[state_or_province] OFF
PRINT(N'Operation applied to 53 rows out of 53')

PRINT(N'Add row to [ods].[business_location]')
SET IDENTITY_INSERT [ods].[business_location] ON
INSERT INTO [ods].[business_location] ([business_location_id], [mobile_business_fk], [address_fk], [location_name], [headquarters_flag], [greenwich_offset], [trade_radius_in_miles], [location_start_date], [location_end_date], [retail_warehouse_indicator], [service_capacity], [service_capacity_treatment_indicator], [last_update_timestamp]) VALUES (6, 18, 1, 'Headquarters', 'y', 0, NULL, '2020-11-08', NULL, NULL, NULL, NULL, '2020-11-08 19:38:41.330')
SET IDENTITY_INSERT [ods].[business_location] OFF

PRINT(N'Add rows to [ods].[mobile_business_business_category]')
SET IDENTITY_INSERT [ods].[mobile_business_business_category] ON
INSERT INTO [ods].[mobile_business_business_category] ([mobile_business_business_category_id], [mobile_business_fk], [business_category_fk], [offer_mode]) VALUES (1, 27, 3, 'G')
INSERT INTO [ods].[mobile_business_business_category] ([mobile_business_business_category_id], [mobile_business_fk], [business_category_fk], [offer_mode]) VALUES (2, 27, 5, 'G')
SET IDENTITY_INSERT [ods].[mobile_business_business_category] OFF
PRINT(N'Operation applied to 2 rows out of 2')

PRINT(N'Add rows to [ods].[product]')
SET IDENTITY_INSERT [ods].[product] ON
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (8, 18, NULL, NULL, 'Model 1000', 550.00, 1100.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 01:14:37.730')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (10, 18, NULL, NULL, 'Model 2000', 550.00, 1100.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 12:21:53.567')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (11, 18, NULL, NULL, 'Model 3000', 550.00, 1100.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 12:31:22.887')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (12, 18, NULL, NULL, 'Model 4000', 550.00, 1100.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 12:32:50.777')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (13, 18, NULL, NULL, 'Model 5000', 550.00, 1100.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 12:34:21.573')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (14, 18, NULL, NULL, 'Model 6000', 550.00, 1100.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 12:37:30.960')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (15, 18, NULL, NULL, 'Model 7000', 550.00, 1100.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 12:40:05.993')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (17, 18, NULL, NULL, 'Model 8000', 540.00, 1100.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 12:43:10.230')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (19, 18, NULL, NULL, 'Model 1000 repair', 95.00, 200.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 13:10:21.787')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (21, 18, NULL, NULL, 'Model 2000 repair', 95.00, 200.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 13:13:23.857')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (22, 18, NULL, NULL, 'Model 3000 repair', 95.00, 200.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'Y', 'Y', 'Y', NULL, NULL, 0.0000, '2020-11-09 13:19:12.467')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (24, 18, NULL, NULL, 'Model 4000 repair', 95.00, 200.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'N', 'N', 'N', NULL, NULL, 0.0000, '2020-11-09 13:28:14.827')
INSERT INTO [ods].[product] ([product_id], [mobile_business_fk], [product_retail_category_fk], [tax_item_type_fk], [text_description], [minimum_price], [maximum_price], [loyalty_points_to_accrue], [likes], [dislikes], [commission_amount], [commission_rate], [unit_of_measure], [physical_or_virtual_indicator], [visable_flag], [default_purchase_mode], [ok_for_pickup_flag], [ok_for_delivery_flag], [ok_for_ship_flag], [service_life_in_days], [service_life_exact_or_category_flag], [commission_ratio], [last_update_timestamp]) VALUES (25, 18, NULL, NULL, 'Model 5000 repair', 95.00, 200.00, 0, 0, 0, NULL, NULL, NULL, 'P', NULL, NULL, 'N', 'N', 'N', NULL, NULL, 0.0000, '2020-11-09 13:29:24.853')
SET IDENTITY_INSERT [ods].[product] OFF
PRINT(N'Operation applied to 13 rows out of 13')

PRINT(N'Add rows to [ods].[good]')
INSERT INTO [ods].[good] ([good_id], [manufacturer_fk], [return_address_fk], [quantity_on_hand], [quantity_available], [weight_in_pounds], [target_quantity], [platform_gets_all_inventory_flag], [reorder_lag_time_in_days], [customizable_flag], [expected_restock_delay_in_days], [last_update_timestamp]) VALUES (15, NULL, NULL, 42, 42, 1, 28, 'Y', NULL, NULL, 0, '2020-11-09 12:42:58.477')
INSERT INTO [ods].[good] ([good_id], [manufacturer_fk], [return_address_fk], [quantity_on_hand], [quantity_available], [weight_in_pounds], [target_quantity], [platform_gets_all_inventory_flag], [reorder_lag_time_in_days], [customizable_flag], [expected_restock_delay_in_days], [last_update_timestamp]) VALUES (17, NULL, NULL, 42, 42, 1, 32, 'Y', NULL, NULL, 0, '2020-11-09 12:43:10.237')
PRINT(N'Operation applied to 2 rows out of 2')

PRINT(N'Add rows to [ods].[professional_service]')
INSERT INTO [ods].[professional_service] ([professional_service_id], [expected_duration_in_minutes], [mean_frequency_of_recurrance_in_days], [service_type], [last_update_timestamp]) VALUES (19, NULL, NULL, '1', '2020-11-09 13:13:05.557')
INSERT INTO [ods].[professional_service] ([professional_service_id], [expected_duration_in_minutes], [mean_frequency_of_recurrance_in_days], [service_type], [last_update_timestamp]) VALUES (21, NULL, NULL, '1', '2020-11-09 13:13:23.860')
INSERT INTO [ods].[professional_service] ([professional_service_id], [expected_duration_in_minutes], [mean_frequency_of_recurrance_in_days], [service_type], [last_update_timestamp]) VALUES (22, NULL, NULL, '1', '2020-11-09 13:19:12.560')
INSERT INTO [ods].[professional_service] ([professional_service_id], [expected_duration_in_minutes], [mean_frequency_of_recurrance_in_days], [service_type], [last_update_timestamp]) VALUES (24, NULL, NULL, '1', '2020-11-09 13:28:14.867')
INSERT INTO [ods].[professional_service] ([professional_service_id], [expected_duration_in_minutes], [mean_frequency_of_recurrance_in_days], [service_type], [last_update_timestamp]) VALUES (25, 45, NULL, '1', '2020-11-09 13:29:24.910')
PRINT(N'Operation applied to 5 rows out of 5')

PRINT(N'Add constraints to [ods].[professional_service]')
ALTER TABLE [ods].[professional_service] WITH CHECK CHECK CONSTRAINT [fk_service_product]
ALTER TABLE [ods].[business_location_service] WITH CHECK CHECK CONSTRAINT [fk_business_location_service_service]
ALTER TABLE [ods].[business_location_service_bay_service] WITH CHECK CHECK CONSTRAINT [fk_businss_location_work_space_service]
ALTER TABLE [ods].[mobile_business_employee_service_qualification] WITH CHECK CHECK CONSTRAINT [fk_employee_service_qualification_service]
ALTER TABLE [ods].[retail_customer_service_calendar_preference] WITH CHECK CHECK CONSTRAINT [fk_retail_customer_service_calendar_preference_service]
ALTER TABLE [ods].[retail_customer_service_location_preference] WITH CHECK CHECK CONSTRAINT [fk_retail_customer_service_location_preference_service]
ALTER TABLE [ods].[retail_customer_service_special_duration] WITH CHECK CHECK CONSTRAINT [fk_retail_customer_service_sd_preference_service]
ALTER TABLE [ods].[retail_customer_servicer_preference] WITH CHECK CHECK CONSTRAINT [fk_retail_customer_servicer_preference_service]

PRINT(N'Add constraints to [ods].[good]')
ALTER TABLE [ods].[good] WITH CHECK CHECK CONSTRAINT [fk_good_manufacturer]
ALTER TABLE [ods].[good] WITH CHECK CHECK CONSTRAINT [fk_good_product]
ALTER TABLE [ods].[good] WITH CHECK CHECK CONSTRAINT [fk_good_return_address]
ALTER TABLE [ods].[business_location_inventory] WITH CHECK CHECK CONSTRAINT [fk_business_location_inventory_good]
ALTER TABLE [ods].[rentable_good] WITH CHECK CHECK CONSTRAINT [fk_rentable_good_good]
ALTER TABLE [ods].[good_vendor_order] WITH CHECK CHECK CONSTRAINT [fk_good_vendor_order_good]

PRINT(N'Add constraints to [ods].[product]')
ALTER TABLE [ods].[product] WITH CHECK CHECK CONSTRAINT [fk_product_mobile_business]
ALTER TABLE [ods].[product] WITH CHECK CHECK CONSTRAINT [fk_product_product_retail_category]
ALTER TABLE [ods].[product] WITH CHECK CHECK CONSTRAINT [fk_product_tax_item_type]
ALTER TABLE [ods].[asset] WITH CHECK CHECK CONSTRAINT [fk_asset_product]
ALTER TABLE [ods].[auction_item] WITH CHECK CHECK CONSTRAINT [fk_auction_item_product]
ALTER TABLE [ods].[auction_product_sugestion] WITH CHECK CHECK CONSTRAINT [fk_auction_product_sugestion_product]
ALTER TABLE [ods].[cart_product] WITH CHECK CHECK CONSTRAINT [fk_cart_item_product]
ALTER TABLE [ods].[dimension_dependent_inventory_record] WITH CHECK CHECK CONSTRAINT [fk_dimensional_product_inventory_product]
ALTER TABLE [ods].[product_applicable_dimension] WITH CHECK CHECK CONSTRAINT [fk_product_product_dimension_product]
ALTER TABLE [ods].[product_customer_review] WITH CHECK CHECK CONSTRAINT [fk_product_customer_review_product]
ALTER TABLE [ods].[product_image] WITH CHECK CHECK CONSTRAINT [Fk_product_image_product]
ALTER TABLE [ods].[product_quantity_discount] WITH CHECK CHECK CONSTRAINT [fk_product_quantity_discount_product]
ALTER TABLE [ods].[product_subscription] WITH CHECK CHECK CONSTRAINT [fk_product_subscription_product]
ALTER TABLE [ods].[product_tag] WITH CHECK CHECK CONSTRAINT [fk_product_tag_product]
ALTER TABLE [ods].[product_terms] WITH CHECK CHECK CONSTRAINT [fk_product_terms_product]
ALTER TABLE [ods].[product_virtue_point_credit] WITH CHECK CHECK CONSTRAINT [Fk_product_virtue_point_credit_product]
ALTER TABLE [ods].[recommendation] WITH CHECK CHECK CONSTRAINT [fk_recomendation_product]
ALTER TABLE [ods].[restock_event] WITH CHECK CHECK CONSTRAINT [fk_restock_event_product]
ALTER TABLE [ods].[restock_requirement] WITH CHECK CHECK CONSTRAINT [fk_restock_requirement_product]
ALTER TABLE [ods].[retail_customer_favorite_product] WITH CHECK CHECK CONSTRAINT [fk_retail_customer_favorite_product_product]
ALTER TABLE [ods].[trusted_trade_prompt_product] WITH CHECK CHECK CONSTRAINT [Fk_trusted_trade_prompt_product_product]
ALTER TABLE [ods].[universal_item_source] WITH CHECK CHECK CONSTRAINT [fk_universal_item_source]
ALTER TABLE [ods].[wishlist] WITH CHECK CHECK CONSTRAINT [fk_wishlist_product]

PRINT(N'Add constraints to [ods].[mobile_business_business_category]')
ALTER TABLE [ods].[mobile_business_business_category] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_business_category_business_category]
ALTER TABLE [ods].[mobile_business_business_category] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_business_category_mobile_business]

PRINT(N'Add constraints to [ods].[business_location]')
ALTER TABLE [ods].[business_location] WITH CHECK CHECK CONSTRAINT [fk_business_location_mobile_business]
ALTER TABLE [ods].[business_location] WITH CHECK CHECK CONSTRAINT [Fk_business_location_post_office_address]
ALTER TABLE [ods].[appointment_reschedule_alternative] WITH CHECK CHECK CONSTRAINT [fk_appointment_reschedule_alternative_business_location]
ALTER TABLE [ods].[business_location_contact_mechanism] WITH CHECK CHECK CONSTRAINT [fk_location_contact_mechanism_business_location]
ALTER TABLE [ods].[business_location_hours_of_operation] WITH CHECK CHECK CONSTRAINT [fk_business_loation_hours_of_operation_business_location]
ALTER TABLE [ods].[business_location_inventory] WITH CHECK CHECK CONSTRAINT [fk_business_location_inventory_business_location]
ALTER TABLE [ods].[business_location_manager] WITH CHECK CHECK CONSTRAINT [fk_business_location_manager_business_location]
ALTER TABLE [ods].[business_location_service] WITH CHECK CHECK CONSTRAINT [fk_business_location_service_business_location]
ALTER TABLE [ods].[business_location_service_bay] WITH CHECK CHECK CONSTRAINT [fk_business_sub_location_business_location]
ALTER TABLE [ods].[business_location_staff] WITH CHECK CHECK CONSTRAINT [fk_business_location_staff_business_location]
ALTER TABLE [ods].[cart] WITH CHECK CHECK CONSTRAINT [fk_cart_business_location]
ALTER TABLE [ods].[mobile_business_employee_location_fillin] WITH CHECK CHECK CONSTRAINT [fk_mobile_business_employee_location_assignment_location_0]
ALTER TABLE [ods].[retail_customer_service_location_preference] WITH CHECK CHECK CONSTRAINT [fk_retail_customer_service_location_preference_location]

PRINT(N'Add constraints to [ods].[state_or_province]')
ALTER TABLE [ods].[state_or_province] WITH CHECK CHECK CONSTRAINT [Fk_state_or_province_country]

PRINT(N'Add constraints to [ods].[post_office_address]')
ALTER TABLE [ods].[post_office_address] WITH CHECK CHECK CONSTRAINT [fk_address_contact_mechansim]
ALTER TABLE [ods].[cart] WITH CHECK CHECK CONSTRAINT [Fk_cart_shipping_address_fk]
ALTER TABLE [ods].[cleansed_address] WITH CHECK CHECK CONSTRAINT [fk_cleansed_address_provided_address]
ALTER TABLE [ods].[mobile_business] WITH CHECK CHECK CONSTRAINT [fk_mobile_business_return_address]
ALTER TABLE [ods].[party_saved_credit_card] WITH CHECK CHECK CONSTRAINT [Fk_retail_customer_saved_credit_card_post_office_address]
ALTER TABLE [ods].[product_retail_category] WITH CHECK CHECK CONSTRAINT [fk_product_retail_category_return_address]
ALTER TABLE [ods].[product_subscription] WITH CHECK CHECK CONSTRAINT [fk_product_subscription_delivery_address]

PRINT(N'Add constraints to [ods].[platform_virtue_grade]')
ALTER TABLE [ods].[platform_virtue_grade] WITH CHECK CHECK CONSTRAINT [Fk_platform_virtue_grade_virtue]
ALTER TABLE [ods].[mobile_business_loyalty_grade_threshold] WITH CHECK CHECK CONSTRAINT [fk_mobile_business_loyalty_grade_threshold_platform_loyalty_grade]

PRINT(N'Add constraints to [ods].[platform_objective]')
ALTER TABLE [ods].[platform_objective] WITH CHECK CHECK CONSTRAINT [Fk_platform_objective_platform_participation_type]
ALTER TABLE [ods].[party_platform_objective_priority] WITH CHECK CHECK CONSTRAINT [Fk_party_platform_objective_priorityPlatform_objective]

PRINT(N'Add constraints to [ods].[party_contact_mechanism]')
ALTER TABLE [ods].[party_contact_mechanism] WITH CHECK CHECK CONSTRAINT [fk_party_contact_mechanism_contact_mechanism]
ALTER TABLE [ods].[party_contact_mechanism] WITH CHECK CHECK CONSTRAINT [fk_party_contact_mechanism_party]
ALTER TABLE [ods].[cart_points_awarded] WITH CHECK CHECK CONSTRAINT [Fk_cart_points_awarded_virtue]
ALTER TABLE [ods].[mobile_business_virtue_ranking] WITH CHECK CHECK CONSTRAINT [fk_mobile_business_ranking_of_virtues_vurtue]
ALTER TABLE [ods].[mobile_business_virtue_score] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_virtue_score_virtue]
ALTER TABLE [ods].[product_virtue_point_credit] WITH CHECK CHECK CONSTRAINT [Fk_product_virtue_point_credit_virtue]
ALTER TABLE [ods].[retail_customer_virtue_points] WITH CHECK CHECK CONSTRAINT [Fk_retail_customer_virtue_points_virtue]
ALTER TABLE [ods].[universal_virtue_grade] WITH CHECK CHECK CONSTRAINT [Fk_universal_virtue_grade_virtue]
ALTER TABLE [ods].[trusted_trade_prompt] WITH CHECK CHECK CONSTRAINT [Fk_trusted_trade_prompt_trusted_trade_type]
ALTER TABLE [ods].[mobile_business] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_transaction_per_month_bracket]
ALTER TABLE [ods].[mobile_business] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_transaction_size_bracket]
ALTER TABLE [ods].[mobile_business] WITH CHECK CHECK CONSTRAINT [fk_mobile_buisness]
ALTER TABLE [ods].[product_retail_category] WITH CHECK CHECK CONSTRAINT [fk_product_category_tax_item_type]
ALTER TABLE [ods].[mobile_business] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_service_area_bracket]
ALTER TABLE [ods].[party_language_preference] WITH CHECK CHECK CONSTRAINT [Fk_party_language_preference_platform_supported_language]
ALTER TABLE [ods].[mobile_business] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_theme]
ALTER TABLE [ods].[mobile_business] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_color]
ALTER TABLE [ods].[message_category_role_based_recipient] WITH CHECK CHECK CONSTRAINT [fk_message_category_role_based_recipient_platform_role]
ALTER TABLE [ods].[mobile_business_employee_authorization_group_role] WITH CHECK CHECK CONSTRAINT [fk_mobilebusiness_to_partyrole_partyrole]
ALTER TABLE [ods].[role_operational_function] WITH CHECK CHECK CONSTRAINT [fk_role_operational_function_role]
ALTER TABLE [ods].[party_image] WITH CHECK CHECK CONSTRAINT [Fk_party_image_platform_participation_type]
ALTER TABLE [ods].[party_platform_objective_priority] WITH CHECK CHECK CONSTRAINT [Fk_party_platform_objective_priority_platform_participation_type]
ALTER TABLE [ods].[person_as_user] WITH CHECK CHECK CONSTRAINT [Fk_person_as_user_platform_participation_type]
ALTER TABLE [ods].[role_operational_function] WITH CHECK CHECK CONSTRAINT [fk_role_operational_function_operational_function]
ALTER TABLE [ods].[mobile_business] WITH CHECK CHECK CONSTRAINT [Fk_mobile_business_platform_mobile_business_monthly_volume_bracket]
ALTER TABLE [ods].[business_location_contact_mechanism] WITH CHECK CHECK CONSTRAINT [fk_location_contact_mechanism_contact_mechanism]
ALTER TABLE [ods].[device] WITH CHECK CHECK CONSTRAINT [fk_device_contact_mechanism]
ALTER TABLE [ods].[email_address] WITH CHECK CHECK CONSTRAINT [fk_email_address_contact_mechanism]
ALTER TABLE [ods].[person] WITH CHECK CHECK CONSTRAINT [fk_person_adddress]
ALTER TABLE [ods].[restock_alert] WITH CHECK CHECK CONSTRAINT [fk_restock_alert_contact_mechanism]
ALTER TABLE [ods].[business_category_retail_customer_activity_measure] WITH CHECK CHECK CONSTRAINT [Fk_business_catgegory_retail_customer_activity_measure_business_cat]
ALTER TABLE [ods].[dimension_source_business_category] WITH CHECK CHECK CONSTRAINT [fk_dimension_source_business_category_business_category]
COMMIT TRANSACTION
GO
