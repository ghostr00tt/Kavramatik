using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kavramatik.cs
{
    class Score
    {
        public String user_email { get; set; }
        public int score { get; set; }
        public Score(String user_email, int score)
        {
            this.user_email = user_email;
            this.score = score;
        }

    }

    class Opposities
    {
        public string id { get; set; }
        public string category_name { get; set; }
        public string category_name_slug { get; set; }
        public string category_image { get; set; }
        public string order { get; set; }
        public string route { get; set; }
    }

  public class colors{
        public string id { get; set; }
        public string color { get; set; }
        public string color_name { get; set; }
        public string color_tag { get; set; }
        public string color_one { get; set; }
        public string color_two { get; set; }
        public string one_tag { get; set; }
        public string two_tag { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }


    }

  public class dimensions{
        public string id { get; set; }
        public string dimension_name { get; set; }
        public string dimension_text { get; set; }
        public string dimension_one_text { get; set; }
        public string dimension_two_text { get; set; }
        public string dimension_one_image { get; set; }
        public string dimension_two_image { get; set; }
        public string created_at{ get; set; }
        public string updated_at{ get; set; }
    }

    public class shapes
    {
        public string id { get; set; }
        public string shape_name { get; set; }
        public string shape_text { get; set; }
        public string shape_image { get; set; }
        public string shape_two_text { get; set; }
        public string shape_two_image { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class quantities
    {
        public string id { get; set; }
        public string quantitiy_name { get; set; }
        public string quantitiy_text { get; set; }
        public string quantitiy_one_text { get; set; }
        public string quantitiy_two_text { get; set; }
        public string quantitiy_one_image { get; set; }
        public string quantitiy_two_image { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public  class directions
    {
        public string id { get; set; }
        public string direction_name { get; set; }
        public string direction_text { get; set; }
        public string direction_image { get; set; }
        public string direction_two { get; set; }
        public string direction_two_text { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class numbers
    {
        public string id { get; set; }
        public string number_name { get; set; }
        public string number_one_text { get; set; }
        public string number_quantity_text { get; set; }
        public string number_one_image { get; set; }
        public string number_quantity_image { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

    }

    public class senses
    {
        public string id { get; set; }
        public string sense_name { get; set; }
        public string sense_one_image_text { get; set; }
        public string sense_two_image_text { get; set; }
        public string sense_one_image { get; set; }
        public string sense_two_image { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class opposities
    {
        public string id { get; set; }
        public string opposite_name { get; set; }
        public string opposite_one_image_text { get; set; }
        public string opposite_two_image_text { get; set; }
        public string opposite_one_image { get; set; }
        public string opposite_two_image { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class emotions
    {
        public string id { get; set; }
        public string emotion_name { get; set; }
        public string emotion_text { get; set; }
        public string emotion_image { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}
