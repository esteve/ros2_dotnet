/* Copyright 2016-2018 Esteve Fernandez <esteve@apache.org>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace ROS2 {


  class NodeNameInvalidIsEmptyStringException : Exception
  {
    public NodeNameInvalidIsEmptyStringException()
    {
    }

    public NodeNameInvalidIsEmptyStringException(string rmw_error_string)
        : base(rmw_error_string)
    {
    }
  }

  class NodeNameInvalidContainsUnallowedCharactersException : Exception
  {
    public NodeNameInvalidContainsUnallowedCharactersException()
    {
    }

    public NodeNameInvalidContainsUnallowedCharactersException(string rmw_error_string)
        : base(rmw_error_string)
    {
    }
  }

  class NodeNameInvalidStartsWithNumberException : Exception
  {
    public NodeNameInvalidStartsWithNumberException()
    {
    }

    public NodeNameInvalidStartsWithNumberException(string rmw_error_string)
        : base(rmw_error_string)
    {
    }
  }

  class NodeNameInvalidTooLongException : Exception
  {
    public NodeNameInvalidTooLongException()
    {
    }

    public NodeNameInvalidTooLongException(string rmw_error_string)
        : base(rmw_error_string)
    {
    }
  }

  class AlreadyInitException : Exception
  {
    public AlreadyInitException()
    {
    }

    public AlreadyInitException(string rcl_error_string)
        : base(rcl_error_string)
    {
    }
  }

  class InvalidArgumentException : Exception
  {
    public InvalidArgumentException()
    {
    }

    public InvalidArgumentException(string rcl_error_string)
        : base(rcl_error_string)
    {
    }
  }

  class BadAllocException : Exception
  {
    public BadAllocException()
    {
    }

    public BadAllocException(string rcl_error_string)
        : base(rcl_error_string)
    {
    }
  }

  class NodeInvalidNameException : Exception
  {
    public NodeInvalidNameException()
    {
    }

    public NodeInvalidNameException(string rcl_error_string)
        : base(rcl_error_string)
    {
    }
  }

  class NodeInvalidNamespaceException : Exception
  {
    public NodeInvalidNamespaceException()
    {
    }

    public NodeInvalidNamespaceException(string rcl_error_string)
        : base(rcl_error_string)
    {
    }
  }

}
